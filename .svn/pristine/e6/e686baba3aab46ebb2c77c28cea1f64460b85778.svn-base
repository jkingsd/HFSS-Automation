using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace clsHFSSExtract
{
    public class clsHFSSFile
    {
    }

    public class SimSetupInfo
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }

    public class clsHFSSExtr
    {
        private string strFileName;
        private List<string> strVariableList = new List<string>();
        List<string> tline = new List<string>();

        public string HFSSFileName
        {
            get
            { return strFileName; }
            set
            { 
                strFileName = value;
                LoadFile();
            }
        }

        private void LoadFile()
        {
            using (StreamReader rFile = File.OpenText(strFileName))
            {
                while (!rFile.EndOfStream)
                {
                    tline.Add(rFile.ReadLine());
                }
            }
        }

        private void BuildVariableList()
        {
            //string line;
            char[] TrimChar = { '\'', ' ' };
            int ctr = 0;

            while (!tline[ctr].Contains("$end 'AnsoftProject'"))
            {
                if (tline[ctr].Contains("$begin 'HFSSModel'"))
                {
                    bool NameParsed = false;
                    string SetupName = "";
                    Dictionary<string, SimSetupInfo> SimSetup = new Dictionary<string, SimSetupInfo>();

                    while (!tline[ctr].Contains("$end 'HFSSModel'"))
                    {
                        if (tline[ctr].Contains("Name") & !NameParsed)
                        {
                            SetupName = (tline[ctr].Split('=')).Last().Trim(TrimChar);
                            NameParsed = true;
                        }
                        else if (tline[ctr].Contains("$begin 'ID Map'"))
                        {
                            while (!tline[ctr].Contains("$end 'ID Map'"))
                            {
                                if (tline[ctr].Contains("$begin 'Setup'"))
                                {
                                    string[] SetupLine = null;
                                    SimSetupInfo cSetup = new SimSetupInfo();

                                    while (!tline[ctr].Contains("$end 'Setup'"))
                                    {
                                        if (!tline[ctr].Contains("Soln"))
                                        {
                                            SetupLine = tline[ctr].Trim().Split('=');

                                            switch (SetupLine[0])
                                            {
                                                case "N":
                                                    cSetup.Name = SetupLine[1].Trim(TrimChar);
                                                    break;

                                                case "I":
                                                    cSetup.Id = Convert.ToInt32(SetupLine[1].Trim(TrimChar));
                                                    break;
                                            }
                                        }

                                        ctr++;
                                    }

                                    SimSetup[cSetup.Name] = cSetup;
                                }

                                ctr++;
                            }

                            //_Setups.Setups.Add(SetupName, SimSetup);
                        }

                        ctr++;
                    }
                }

                ctr++;
            }
        }  
    }


    //public class clsHFSSProjectVariableList : System.Collections.CollectionBase
    //{
    //    public void clear()
    //    {
    //        List.Clear();
    //    }

    //    public void insert(int index, double value)
    //    {
    //        List.Insert(index, value);
    //    }

    //    public bool contains(double value)
    //    {
    //        return List.Contains(value);
    //    }

    //    public List<string> VariableList()
    //    {
    //        List<string> tline = new List<string>();

    //        using (StreamReader rFile = File.OpenText("test.hfss"))
    //        {
    //            while (!rFile.EndOfStream)
    //            {
    //                tline.Add(rFile.ReadLine());
    //            }
    //        }
                   
    //            try
    //            {
    //                //string line;
    //                char[] TrimChar = { '\'', ' ' };
    //                int ctr = 0;

    //                _Setups.HfssFile = HfssFile[0];

    //                List<string> tline = new List<string>();

    //                using (StreamReader rFile = File.OpenText(HfssFile[0]))
    //                {
    //                    while (!rFile.EndOfStream)
    //                    {
    //                        tline.Add(rFile.ReadLine());
    //                    }
    //                }

    //                while (!tline[ctr].Contains("$end 'AnsoftProject'"))
    //                {
    //                    if (tline[ctr].Contains("$begin 'HFSSModel'"))
    //                    {
    //                        bool NameParsed = false;
    //                        string SetupName = "";
    //                        Dictionary<string, SimSetupInfo> SimSetup = new Dictionary<string, SimSetupInfo>();

    //                        while (!tline[ctr].Contains("$end 'HFSSModel'"))
    //                        {
    //                            if (tline[ctr].Contains("Name") & !NameParsed)
    //                            {
    //                                SetupName = (tline[ctr].Split('=')).Last().Trim(TrimChar);
    //                                NameParsed = true;
    //                            }
    //                            else if (tline[ctr].Contains("$begin 'ID Map'"))
    //                            {
    //                                while (!tline[ctr].Contains("$end 'ID Map'"))
    //                                {
    //                                    if (tline[ctr].Contains("$begin 'Setup'"))
    //                                    {
    //                                        string[] SetupLine = null;
    //                                        SimSetupInfo cSetup = new SimSetupInfo();

    //                                        while (!tline[ctr].Contains("$end 'Setup'"))
    //                                        {
    //                                            if (!tline[ctr].Contains("Soln"))
    //                                            {
    //                                                SetupLine = tline[ctr].Trim().Split('=');

    //                                                switch (SetupLine[0])
    //                                                {
    //                                                    case "N":
    //                                                        cSetup.Name = SetupLine[1].Trim(TrimChar);
    //                                                        break;

    //                                                    case "I":
    //                                                        cSetup.Id = Convert.ToInt32(SetupLine[1].Trim(TrimChar));
    //                                                        break;
    //                                                }
    //                                            }

    //                                            ctr++;
    //                                        }

    //                                        SimSetup[cSetup.Name] = cSetup;
    //                                    }

    //                                    ctr++;
    //                                }

    //                                _Setups.Setups.Add(SetupName, SimSetup);
    //                            }

    //                            ctr++;
    //                        }
    //                    }

    //                    ctr++;
    //                }

    //                return _Setups;
    //            }
    //            catch (Exception err)
    //            {
    //                _Setups.Setups.Add("Error: " + err.Message, null);
    //                return _Setups;
    //            }
    //        }
        
    //}

    /// <summary>
    /// section to identify solution names, setup names, and solver names DJ 
    /// </summary>
    /// 
    public class DropDownFill
    {
        //public List<string> Solutions()
        //{
        //    MQueue _queue = new MQueue();
        //    List<string> SolutionList = new List<string>();
        //    SolutionList = Directory.GetDirectories(_queue.ProjectPath + @"HFSS").ToList<string>();
        //    SolutionList.Insert(0, "Select Solution");

        //    return SolutionList;
        //}

        //public Hfss_Setup Setups(string inSolution)
        //{
        //    string[] HfssFile = Directory.GetFiles(inSolution, "*.hfss");
        //    Hfss_Setup _Setups = new Hfss_Setup();

        //    //initialize list
        //    _Setups.Setups = new Dictionary<string, Dictionary<string, SimSetupInfo>>();

        //    if (HfssFile.Count() > 1)
        //    {
        //        _Setups.HfssFile = "Error: Multiple .hfss Files Found";
        //        _Setups.Setups.Add("Error: Multiple .hfss Files Found", null);
        //        return _Setups;
        //    }
        //    else
        //    {
        //        try
        //        {
        //            //string line;
        //            char[] TrimChar = { '\'', ' ' };
        //            int ctr = 0;

        //            _Setups.HfssFile = HfssFile[0];

        //            List<string> tline = new List<string>();

        //            using (StreamReader rFile = File.OpenText(HfssFile[0]))
        //            {
        //                while (!rFile.EndOfStream)
        //                {
        //                    tline.Add(rFile.ReadLine());
        //                }
        //            }

        //            while (!tline[ctr].Contains("$end 'AnsoftProject'"))
        //            {
        //                if (tline[ctr].Contains("$begin 'HFSSModel'"))
        //                {
        //                    bool NameParsed = false;
        //                    string SetupName = "";
        //                    Dictionary<string, SimSetupInfo> SimSetup = new Dictionary<string, SimSetupInfo>();

        //                    while (!tline[ctr].Contains("$end 'HFSSModel'"))
        //                    {
        //                        if (tline[ctr].Contains("Name") & !NameParsed)
        //                        {
        //                            SetupName = (tline[ctr].Split('=')).Last().Trim(TrimChar);
        //                            NameParsed = true;
        //                        }
        //                        else if (tline[ctr].Contains("$begin 'ID Map'"))
        //                        {
        //                            while (!tline[ctr].Contains("$end 'ID Map'"))
        //                            {
        //                                if (tline[ctr].Contains("$begin 'Setup'"))
        //                                {
        //                                    string[] SetupLine = null;
        //                                    SimSetupInfo cSetup = new SimSetupInfo();

        //                                    while (!tline[ctr].Contains("$end 'Setup'"))
        //                                    {
        //                                        if (!tline[ctr].Contains("Soln"))
        //                                        {
        //                                            SetupLine = tline[ctr].Trim().Split('=');

        //                                            switch (SetupLine[0])
        //                                            {
        //                                                case "N":
        //                                                    cSetup.Name = SetupLine[1].Trim(TrimChar);
        //                                                    break;

        //                                                case "I":
        //                                                    cSetup.Id = Convert.ToInt32(SetupLine[1].Trim(TrimChar));
        //                                                    break;
        //                                            }
        //                                        }

        //                                        ctr++;
        //                                    }

        //                                    SimSetup[cSetup.Name] = cSetup;
        //                                }

        //                                ctr++;
        //                            }

        //                            _Setups.Setups.Add(SetupName, SimSetup);
        //                        }

        //                        ctr++;
        //                    }
        //                }

        //                ctr++;
        //            }

        //            return _Setups;
        //        }
        //        catch (Exception err)
        //        {
        //            _Setups.Setups.Add("Error: " + err.Message, null);
        //            return _Setups;
        //        }
        //    }
        //}

        //public List<ProfileItems> ProfileData(string FileName, string SetupName, int SimSetup) //Read .hfss file -DJ
        //{
        //    string ProfilePath = (FileName.Split('.'))[0] + ".hfssresults\\" +
        //        SetupName + ".results\\";

        //    List<ProfileItems> ProfileData = new List<ProfileItems>();

        //    if (!Directory.Exists(ProfilePath))
        //    {
        //        ProfileData = new List<ProfileItems>();
        //        ProfileData.Add(new ProfileItems() { Information = "No " + SetupName + ".Results Found" });

        //        return ProfileData;
        //    }

        //    string[] ProfileFile = Directory.GetFiles(ProfilePath, "*_S" + SimSetup + "*.profile");

        //    if (ProfileFile.Count() == 0)
        //    {
        //        ProfileData = new List<ProfileItems>();
        //        ProfileData.Add(new ProfileItems() { Information = @"Error: No .profile file detected." });

        //        return ProfileData;
        //    }
        //    else
        //    {
        //        try
        //        {
        //            char[] TrimChar = { '\'', ' ' };
        //            List<string> tline = new List<string>();

        //            using (StreamReader rFile = File.OpenText(ProfileFile.Last()))
        //            {
        //                while (!rFile.EndOfStream)
        //                {
        //                    tline.Add(rFile.ReadLine());
        //                }
        //            }

        //            string[] line = tline.ToArray();

        //            for (int row = 0; row < line.Count(); row++)
        //            {
        //                if (line[row].Contains("$begin 'ProfileGroup'"))
        //                {
        //                    //get start time
        //                    row++;
        //                    ProfileData.Add(new ProfileItems()
        //                    {
        //                        Task = "Start Information",
        //                        Information = line[row].Split('=')[1].Trim(TrimChar)
        //                    });

        //                    //get total information
        //                    row++;
        //                    ProfileData.Add(new ProfileItems()
        //                    {
        //                        Task = "Total Information",
        //                        Information = line[row].Split('=')[1].Trim(TrimChar)
        //                    });

        //                    bool _profileTask = true;

        //                    while (_profileTask)
        //                    {
        //                        row++;

        //                        if (line[row].Contains("ProfileTask"))
        //                        {
        //                            ProfileItems NewItem = new ProfileItems();

        //                            double _memory = Convert.ToInt32(((line[row].Split('\''))[2].Split(','))[5].Trim(TrimChar)) == 0 ? 0 :
        //                            (Convert.ToDouble(((line[row].Split('\''))[2].Split(','))[5].Trim(TrimChar)) / 1024000);

        //                            TimeSpan _realtime = new TimeSpan(0, 0, Convert.ToInt32(((line[row].Split('\''))[2].Split(','))[1].Trim(TrimChar)));
        //                            TimeSpan _cputime = new TimeSpan(0, 0, Convert.ToInt32(((line[row].Split('\''))[2].Split(','))[3].Trim(TrimChar)));

        //                            NewItem.Task = (line[row].Split('\''))[1].Trim(TrimChar);
        //                            NewItem.RealTime = _realtime.Ticks == 0 ? " " : _realtime.ToString();
        //                            NewItem.CpuTime = _cputime.Ticks == 0 ? " " : _cputime.ToString();
        //                            NewItem.Memory = (_memory == 0 ? " " : (_memory.ToString("F3") + "G"));
        //                            NewItem.Information = (line[row].Split('\''))[3].Trim(TrimChar);

        //                            ProfileData.Add(NewItem);
        //                        }
        //                        else
        //                        {
        //                            ProfileData.Add(new ProfileItems());
        //                            ProfileData.Add(new ProfileItems());
        //                            _profileTask = false;
        //                        }
        //                    }
        //                }
        //            }

        //            return ProfileData;

        //        }
        //        catch (Exception err)
        //        {
        //            ProfileData = new List<ProfileItems>();
        //            ProfileData.Add(new ProfileItems() { Information = err.Message });

        //            return ProfileData;
        //        }
        //    }
        //}

    }

}
