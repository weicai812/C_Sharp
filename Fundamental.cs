using System;

class Program {
    static void Main() {
        Console.Write("Enter Your Password: ");
        string pattern = Console.ReadLine();
        char[] password = pattern.ToCharArray();
        
        Random ranMachine = new Random();
        
        for(int i=0; i<password.Length; i++){
            if(password[i]== '*'){
                password[i] = Convert.ToChar(ranMachine.Next(97,122));
            }
        }
        
        string newPassword = String.Join("",password);
        Console.WriteLine(newPassword);
    }
}
