using System;

namespace EntityFrameworkDz02DataBaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MCSEntities db = new MCSEntities())
            {
                var data = db.TablesModel;

                foreach (var item in data)
                {
                    Console.WriteLine("intModelID: {0}", item.intModelID);
                    Console.WriteLine("intManufacturerID: {0}", item.intManufacturerID);
                    Console.WriteLine("intSMCSFamilyID: {0}", item.intSMCSFamilyID);
                    Console.WriteLine("strName: {0}", item.strName);
                    Console.WriteLine("strImage: {0}", item.strImage);
                    Console.WriteLine();
                }


                //TablesModel tm = new TablesModel();
                //tm.intSMCSFamilyID = 100;
                //tm.strImage = "img.jpeg";
                //tm.strName = "ASDF-16";

                //db.TablesModel.Add(tm);
                //db.SaveChanges();
                //Console.WriteLine("Объекты успешно сохранены");
            }
        }
    }
}
