namespace Biblioteca.Models
{
    public class Usuario
    {

        public static int ADMIN = 0;
        public static int PADRAO = 1;
        public static int SECRETARIA = 2;
        public static int PROFESSOR = 3;
        public static int ALUNO = 4;



        public int Id {get;set;}
        public string Nome {get;set;}
        public string Login {get;set;}
        public string Senha {get;set;}
        public int Tipo {get;set;}
    }
}