using SEDC.CSharpAdv.VideoRental.Data.DataBase;
using SEDC.CSharpAdv.VideoRental.Data.Models;
using SEDC.CSharpAdv.VideoRental.Services.Helpers;
using SEDC.CSharpAdv.VideoRental.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SEDC.CSharpAdv.VideoRental.Services.Services
{
    public class UserService  : IUserService
    {
        private UserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public User Login()
        {
            while(true)
            {
                Console.WriteLine("Enter card number:");
                int idCard = InputParser.ToInteger(100, 999);

                User user = _userRepository.GetUserByIdCard(idCard);
                //loding indicator
                if (user != null)
                {
                    //RenewSubscription
                    RenewSubscription(user);
                    Console.WriteLine($"Welcoome {user.FullName}");
                    return user;
                }
                Console.WriteLine("Card id does not exist");
                Console.WriteLine("Try again y/n");
                while(!InputParser.ToConfirm())
                {
                    Console.WriteLine("Thank you for using rent a video app.");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                }
            }
        }

        public User SignUp()
        {
            while(true)
            {
                Console.Write("Enter fill name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter date of birth");
                DateTime dob = InputParser.ToDateTime();
                int cardNumber = GenerateNewCardNumber();

                Console.WriteLine("Creating user please wait..");
                //loading indicator

                User user = new User
                {
                    CardNumber = cardNumber,
                    FullName = name,
                    DateoOfBirth = dob
                };
                _userRepository.Insert(user);
                return user;
            }
        }

        private int GenerateNewCardNumber()
        {
            const int max = 999;
            const int min = 100;
            Random rnd = new Random();
            List<int> takenCardNumbers = _userRepository.GetAllCardNumbers();

            int cardNumber;
            do
            {
                cardNumber = rnd.Next(min, max);

            } 
            while (takenCardNumbers.Contains(cardNumber));
            return cardNumber;
            
        }

        private void RenewSubscription(User user)
        {
            if(user.SubscriptionExpireTime < DateTime.Now)
            {
                user.IsSubscriptionExpierd = true;
            }

            if (user.IsSubscriptionExpierd)
            {
                Console.WriteLine("Your subscription is expired. Do ypu want to renew y/n?");
                bool renew = InputParser.ToConfirm();
                //loding indicator;

                if(!renew)
                {
                    Console.WriteLine("Thank you for using rent a video app.");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                }
                else
                {
                    user.IsSubscriptionExpierd = false;
                    user.SubscriptionExpireTime = DateTime.Now.AddYears(1);
                    Console.WriteLine($"Your subscription is extended until {user.SubscriptionExpireTime.ToShortDateString()}");
                }
            }
        }

          
    }
}
