using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patlab4
{
    internal class IdentityMap
    {
        private Dictionary<int, Vehicle> vehicleList = new Dictionary<int, Vehicle>();

        public Vehicle GetVehicle(int id, SQLiteConnection con)
        {
            vehicleList.TryGetValue(id, out Vehicle vehicle);
            if (vehicle != null)
            {
                return vehicle;
            }

            using (SQLiteCommand com = new SQLiteCommand("SELECT * FROM vehicles WHERE id = @id", con))
            {
                com.Parameters.AddWithValue("id", id);
                using (SQLiteDataReader reader = com.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        vehicle = new Vehicle(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7) + ".jpg");
                        vehicleList.Add(id, vehicle);
                        return vehicle;
                    }
                }
            }
            return null;
        }
    }
}
