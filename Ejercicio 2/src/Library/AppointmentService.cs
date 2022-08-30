using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            List<String> strs = new List<String> { name, id, phoneNumber, appoinmentPlace, doctorName };

            foreach (string i in strs)
            {
                if (isValid != false)
                    isValid = nullOrEmpty(i);
            }

            /*

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            */

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
            }

            return stringBuilder.ToString();
        }

        public static Boolean nullOrEmpty(String x)
        {
            if (String.IsNullOrEmpty(x))
                return false;
            return true;
        }
    }
}
