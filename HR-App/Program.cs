namespace HR_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = GetValidName();
            string surname = GetValidSurname();

            Console.WriteLine($" {name} {surname}  sisteme elave olundu");
        }

        static string GetValidName()
        {
            while (true)
            {
                Console.WriteLine("Adınızı daxil edin:");
                string name = Console.ReadLine();
                if (IsValidName(name))
                {
                    return name;
                }
                Console.WriteLine("Ad duzgun deyil. Adın uzunluğu 2-20 arasında olmalı ve yalniz herflerden ibaret olmalıdır, ilk herf boyuk olmalıdır.");
            }
        }

        static string GetValidSurname()
        {
            while (true)
            {
                Console.WriteLine("Soyadınızı daxil edin:");
                string surname = Console.ReadLine()!;
                if (IsValidSurname(surname))
                {
                    return surname;
                }
                Console.WriteLine("Soyad duzgun deyil. Soyadın uzunluğu 2-35 arasında olmalı ve yalnız herflerden ibaret olmalıdır, ilk herf böyuk olmalıdır.");
            }
        }

        static string GetValidFatherName()
        {
            while (true)
            {
                Console.WriteLine("Ata adınızı daxil edin:");
                string fatherName = Console.ReadLine()!;
                if (IsValidFatherName(fatherName))
                {
                    return fatherName;
                }
                Console.WriteLine("Ata adı duzgun deyil. Ata adının uzunluğu 2-20 arasında olmalı ve yalnız herflerden ibaret olmalıdır, ilk herf böyuk olmalıdır.");
            }
        }

        static int GetValidAge()
        {
            while (true)
            {
                Console.WriteLine("Yaşınızı daxil edin:");
                string ageInput = Console.ReadLine()!;
                if (int.TryParse(ageInput, out int age) && IsValidAge(age))
                {
                    return age;
                }
                Console.WriteLine("Yaş duzgun deyil. Yaş 18-65 arasında olmalıdır.");
            }
        }

        static string GetValidFIN()
        {
            while (true)
            {
                Console.WriteLine("FIN-i daxil edin:");
                string fin = Console.ReadLine()!;
                if (IsValidFIN(fin))
                {
                    return fin;
                }
                Console.WriteLine("FIN duzgun deyil. FIN uzunluğu 7 olmalı ve yalnız böyuk herfler ve reqemlerden ibaret olmalıdır.");
            }
        }

        static string GetValidPhoneNumber()
        {
            while (true)
            {
                Console.WriteLine("Telefon nömrenizi daxil edin:");
                string phoneNumber = Console.ReadLine()!;
                if (IsValidPhoneNumber(phoneNumber))
                {
                    return phoneNumber;
                }
                Console.WriteLine("Telefon nömresi duzgun deyil. +994 ile başlamalı ve umumi uzunluğu 13 olmalıdır.");
            }
        }

        static string GetValidPosition()
        {
            while (true)
            {
                Console.WriteLine("Pozisiyanızı daxil edin (HR, Audit, Engineer):");
                string position = Console.ReadLine()!;
                if (IsValidPosition(position))
                {
                    return position;
                }
                Console.WriteLine("Pozisiya duzgun deyil. Yalnız HR, Audit ve Engineer ola biler.");
            }
        }

        static int GetValidSalary()
        {
            while (true)
            {
                Console.WriteLine("Maaşınızı daxil edin:");
                string salaryInput = Console.ReadLine()!;
                if (int.TryParse(salaryInput, out int salary) && IsValidSalary(salary))
                {
                    return salary;
                }
                Console.WriteLine("Maaş duzgun deyil. Maaş 1500-5000 arasında olmalıdır.");
            }
        }

        static bool IsValidName(string name)
        {
            if (name.Length < 2 || name.Length > 20) return false;
            if (!IsAllLetters(name)) return false;
            if (!IsUpper(name[0])) return false;
            return true;
        }

        static bool IsValidSurname(string surname)
        {
            if (surname.Length < 2 || surname.Length > 35) return false;
            if (!IsAllLetters(surname)) return false;
            if (!IsUpper(surname[0])) return false;
            return true;
        }

        static bool IsValidFatherName(string fatherName)
        {
            if (fatherName.Length < 2 || fatherName.Length > 20) return false;
            if (!IsAllLetters(fatherName)) return false;
            if (!IsUpper(fatherName[0])) return false;
            return true;
        }

        static bool IsValidAge(int age)
        {
            return age >= 18 && age <= 65;
        }

        static bool IsValidFIN(string fin)
        {
            if (fin.Length != 7) return false;
            foreach (char c in fin)
            {
                if (!IsUpper(c) && !IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsValidPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length != 13) return false;
            if (!StartsWith(phoneNumber, "+994")) return false;
            for (int i = 4; i < phoneNumber.Length; i++)
            {
                if (!IsDigit(phoneNumber[i])) return false;
            }
            return true;
        }

        static bool IsValidPosition(string position)
        {
            return position == "HR" || position == "Audit" || position == "Engineer";
        }

        static bool IsValidSalary(int salary)
        {
            return salary >= 1500 && salary <= 5000;
        }

        static bool IsAllLetters(string str)
        {
            foreach (char c in str)
            {
                if (!IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        static bool StartsWith(string str, string prefix)
        {
            if (str.Length < prefix.Length) return false;
            for (int i = 0; i < prefix.Length; i++)
            {
                if (str[i] != prefix[i])
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsLetter(char c)
        {
            return (c >= 65 && c <= 90) || (c >= 97 && c <= 122);
        }

        static bool IsUpper(char c)
        {
            return c >= 65 && c <= 90;
        }

        static bool IsDigit(char c)
        {
            return c >= 48 && c <= 57;
        }
    }
}
