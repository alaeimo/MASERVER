using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAServer
{
    class DownloadList
    {
         public static List<String> download_list = new List<string>();

        public static void Add_to_List(String File)
        {   if(!download_list.Contains(File))
            download_list.Add(File);
        }

        public static int Get_File_Index(String File) {
           
            return download_list.IndexOf(File);
        }

        public static String GetFile_By_Index(int index) {
            if (index <= download_list.Count())
                return download_list.ElementAt(index);
            else return null;
        }

        public static void Remove_By_Index(int index) {
            if (index <= download_list.Count()-1)
                download_list.RemoveAt(index);
        }

        public static void Clear_All() {
            if(download_list.Count>0)
            download_list.Clear();
        }

        public static bool Check_file_Exist(String File) {
            return download_list.Contains(File);
        }
        public static bool Check_file_Exist(int index)
        {
            return (0<=index && index<= download_list.Count);
        }

        public static String Get_File_by_name(String File) {
            return GetFile_By_Index(Get_File_Index(File));
        }
    }
}
