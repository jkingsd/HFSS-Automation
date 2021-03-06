using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace clsHFSSExtract
{

    public class clsHFSSDesign
    {
        private List<string> strDesignData = new List<string>();
        
        private string strName;  // design name
        private string strSolType;
        private List<string> mstrVariableList = new List<string>(); //variables
        //setups

        public clsHFSSDesign()
        {// create a new design with default values
            strName = "NoDesign";
        }

        public clsHFSSDesign(List<string> DesignTextData)
        {// creates an object representing the design extracted from a .HFSS file
            char[] TrimChar = { '\'', ' ', '\t' };
            //int ln = 0, lastLn = 0;
            bool nameParsed = false;
            string[] strVariableList;

            //for (ln = 0; )
            foreach (string tline in DesignTextData)
            {
                if (tline.Contains("Name") & !nameParsed)
                {
                    strName = (tline.Split('=')).Last().Trim(TrimChar);
                    nameParsed = true;  // name found.
                    //break;
                }
                else if (tline.Contains("VariableProp"))    // find all variables and add to variable list
                {
                    strVariableList = tline.Split('\'');
                    mstrVariableList.Add(strVariableList[1]);   // second string is the variable name
                }
            }
        }

        public List<string> VariableList
        {
            get
            { return mstrVariableList; }            
        }

        public string name
        {
            get
            { return strName; }
        }

        public string solutionType
        {
            get
            { return strSolType; }
        }
    }

    public class clsHFSSProject
    {
        private string strFilePath; // path only, including last '\'
        private string strFileName; // name only, no extension
        private string strCompleteName; // used to reference the file at once
        private List<string> strFileData = new List<string>();

        private List<clsHFSSDesign> dsnTopDesignList = new List<clsHFSSDesign>();

        public clsHFSSProject()
        {// create a new project with default values
            
        }

        public clsHFSSProject(string FileNameWithPath)
        {// creates an object representing the selected file
            strCompleteName = FileNameWithPath;
            int i = strCompleteName.LastIndexOf('\\');
            strFileName = strCompleteName.Substring(i + 1);
            int L = strFileName.Length - 5;
            strFileName = strFileName.Substring(0, L);
            strFilePath = strCompleteName.Substring(0, i + 1);
            //strFilePath = strCompleteName.Substring(0, strCompleteName.Length - strFileName.Length);

            string curLine;
            bool readDesign = false;
            List<string> curDesign = new List<string>();

            using (StreamReader rFile = File.OpenText(strCompleteName))
            {
                while (!rFile.EndOfStream)
                {   // read through the file, and always add the next line to 
                    // the project level record
                    curLine = rFile.ReadLine();
                    strFileData.Add(curLine);
                    if (curLine.Trim() == "$begin \'HFSSModel\'")
                        readDesign = true;
                    // if the beginning of a design definition is encountered
                    if (readDesign)
                        curDesign.Add(curLine);
                    // store the file lines also in another list
                    if (curLine.Trim() == "$end \'HFSSModel\'")
                    {   // when the model definition is finished, 
                        // use the sub-list to define a design object
                        readDesign = false;
                        dsnTopDesignList.Add(new clsHFSSDesign(curDesign));
                        curDesign.Clear();
                    }
                }
            }

            dsnTopDesignList = sortDesignList();

        }

        public string FileName
        {
            get
            { return strFileName; }
        }

        public string Path
        {
            get
            { return strFilePath; }
        }

        public string FileAndPath
        {
            get
            { return strCompleteName; }
            set
            { 
                strCompleteName = value;
                int i = strCompleteName.LastIndexOf('\\');
                strFileName = strCompleteName.Substring(i + 1);
                int L = strFileName.Length - 5;
                strFileName = strFileName.Substring(0, L);
                strFilePath = strCompleteName.Substring(0, strCompleteName.Length - strFileName.Length);
            }
        }
        
        public int lineCount
        {
            get
            { return strFileData.Count; }
        }

        public int designCount
        {
            get
            { return dsnTopDesignList.Count; }
        }

        public clsHFSSDesign getDesign(int index)
        {
            return dsnTopDesignList.ElementAt(index);
        }

        public clsHFSSDesign getDesign(string DesignName)
        {
            foreach (clsHFSSDesign thisDesign in dsnTopDesignList)
            {
                if (thisDesign.name == DesignName)
                    return thisDesign;
            }
            return new clsHFSSDesign();
        }

        public List<string> getDesignNames()
        {
            List<string> allNames = new List<string>();

            foreach (clsHFSSDesign nextDes in dsnTopDesignList)
            {
                allNames.Add(nextDes.name);
            }

            return allNames;

        }

        private List<clsHFSSDesign> sortDesignList()
        {
            List<clsHFSSDesign> sorted = new List<clsHFSSDesign>();
            List<string> desNames = new List<string>();
            Dictionary<string, int> desRefs = new Dictionary<string, int>();
            string desName;

            for (int desIndex = 0; desIndex < dsnTopDesignList.Count; desIndex++)
            {
                desName = dsnTopDesignList.ElementAt(desIndex).name;
                desNames.Add(desName);
                desRefs.Add(desName, desIndex);
            }

            desNames.Sort();

            foreach (string sName in desNames)
            {
                sorted.Add(getDesign(sName));
            }

            return sorted;
        }


    }
}

