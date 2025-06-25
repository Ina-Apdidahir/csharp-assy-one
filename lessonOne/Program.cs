// See https://aka.ms/new-console-template for more information


string name = "Bishar Abdidahir Mohamed";
Console.WriteLine("Name : " + name);

string motherName = "Amina Mohamed";
Console.WriteLine("Mother Name : " + motherName);

string dateOfBirth = "12/12/2001";
string numericDate = dateOfBirth.Replace("/", ""); 
int dateAsInt = Convert.ToInt32(numericDate);

Console.WriteLine("DOB string date : "+ dateOfBirth);
Console.WriteLine("BOB intiger date : "+ dateAsInt);

string placeOfBirth = "galkaio";
Console.WriteLine("Place of Birth : " + placeOfBirth);

string address = "Unisom street Galkaio";
Console.WriteLine("Adress : " + address);

int telPhone = 0907957194;
Console.WriteLine("Phone : " + telPhone);

string sex = "Man";
Console.WriteLine("Sex : " + sex);

string status = "single";
Console.WriteLine("Status : " + status);
