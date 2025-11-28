//namespace Lab4
//{
//    public class UserFinal
//    {
//        public string FinKod { get; set; }
//        public string Name { get; set; }
//        public string Surname { get; set; }
//        public DateTime BirthDate { get; set; }

//        public UserFinal(string f, string n, string s, DateTime b)
//        {
//            FinKod = f;
//            Name = n;
//            Surname = s;
//            BirthDate = b;
//        }
//    }

//    public class BankCard
//    {
//        public string FinKod { get; set; }
//        public string CardNumber { get; set; }
//        public DateTime ExpirationDate { get; set; }
//        public int CVV { get; set; }
//        public double Balance { get; set; } = 0;

//        public BankCard(string fin, string card, DateTime exp, int cvv)
//        {
//            FinKod = fin;
//            CardNumber = card;
//            ExpirationDate = exp;
//            CVV = cvv;
//        }
//    }

//    public class Bank
//    {
//        public List<UserFinal> Users { get; set; } = new List<UserFinal>();
//        public List<BankCard> Cards { get; set; } = new List<BankCard>();
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Bank bank = new Bank();


//            UserFinal user1 = new UserFinal("F123", "Murad", "Kerimli", new DateTime(2003, 5, 25));
//            bank.Users.Add(user1);


//            BankCard card1 = new BankCard("F123", "1234-5678-9876-5432", new DateTime(2030, 12, 31), 123);
//            bank.Cards.Add(card1);


//            Console.WriteLine($"User: {bank.Users[0].Name} {bank.Users[0].Surname}");
//            Console.WriteLine($"Card Number: {bank.Cards[0].CardNumber}");
//        }
//    }
//}
