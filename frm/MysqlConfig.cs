using IniParser;
using IniParser.Model;
using System;
using System.Windows.Forms;

namespace HalleyImport.JMM
{
    public class MysqlObject
    {
        public string Database = "";
        public string Server = "";
        public string Port = "";
        public string UserID = "";
        public string Password = "";

        public MysqlObject() { }
        public MysqlObject(string _database, string _server, string _port, string _userID, string _password)
        {
            Database = _database;
            Server = _server;
            Database = _port;
            UserID = _userID;
            Password = _password;
        }

        // Allow to retreive configurations
        public static MysqlObject LoadMysqlConfiguration(string profile, bool ProfileFolder = false)
        {
            var parser = new FileIniDataParser();
            IniData data;

            try
            {
                if (ProfileFolder)
                {
                    data = parser.ReadFile($@"config\{profile}");
                }
                else
                {
                    data = parser.ReadFile($"{profile}.ini");
                }

                MysqlObject mysqlObject = new MysqlObject();

                profile = profile.Replace(".ini", ""); //tmp fix
                mysqlObject.Database = data[profile]["Database"].Trim();
                mysqlObject.Server = data[profile]["Server"].Trim();
                mysqlObject.Port = data[profile]["Port"].Trim();
                mysqlObject.UserID = data[profile]["UserID"].Trim();
                mysqlObject.Password = data[profile]["Password"].Trim();
                return mysqlObject;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to retreive configuration!\n\nProfile:{profile}\nProfileFolder:{ProfileFolder}\n\n{ex}");
            }
            return null;
        }
    }
}
