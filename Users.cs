using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAServer
{
    class Users
    {
        public static List<String> user_list = new List<String>();

        public static void Add_to_List(String user)
        {
            if (!user_list.Contains(user))
                user_list.Add(user);
        }

        //public static int Get_User_Index(User user)
        //{

        //    return user_list.IndexOf(user);
        //}

        //public static String Getuser_By_Index(int index)
        //{
        //    if (index <= user_list.Count())
        //        return user_list.ElementAt(index);
        //    else return null;
        //}

        //public static void Remove_By_Index(int index)
        //{
        //    if (index <= user_list.Count() - 1)
        //        user_list.RemoveAt(index);
        //}

        //public static void Clear_All()
        //{
        //    if (user_list.Count > 0)
        //        user_list.Clear();
        //}

        //public static bool Check_user_Exist(String user)
        //{
        //    return user_list.Contains(user);
        //}
        //public static bool Check_user_Exist(int index)
        //{
        //    return (0 <= index && index <= user_list.Count);
        //}

        //public static String Get_user_by_name(String user)
        //{
        //    return Getuser_By_Index(Get_user_Index(user));
        //}
    }
}
