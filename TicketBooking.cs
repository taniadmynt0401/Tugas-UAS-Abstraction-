using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{

    namespace TicketBookingApp
    {
        abstract class TicketBooking
        {
            protected string name;
            protected string vaccinationCardNumber;
            protected string nik;
            protected string phoneNumber;
            protected string cardNumber;

            public abstract void GetUserInput();

            public void BookTicket()
            {
                Console.WriteLine("Tiket berhasil dipesan untuk:");
                Console.WriteLine("Nama: " + name);
                Console.WriteLine("Nomor Kartu Vaksin: " + vaccinationCardNumber);
                Console.WriteLine("NIK: " + nik);
                Console.WriteLine("Nomor Telepon: " + phoneNumber);
                Console.WriteLine("Nomor Kartu: " + cardNumber);
            }
        }

        class RegularTicket : TicketBooking
        {
            public override void GetUserInput()
            {
                Console.Write("Masukkan Nama: ");
                name = Console.ReadLine();
                Console.Write("Masukkan Nomor Kartu Vaksin: ");
                vaccinationCardNumber = Console.ReadLine();
                Console.Write("Masukkan NIK: ");
                nik = Console.ReadLine();
                Console.Write("Masukkan Nomor Telepon: ");
                phoneNumber = Console.ReadLine();
                Console.Write("Masukkan Nomor Kartu: ");
                cardNumber = Console.ReadLine();
            }
        }

        class VipTicket : TicketBooking
        {
            public override void GetUserInput()
            {
                Console.Write("Masukkan Nama: ");
                name = Console.ReadLine();
                Console.Write("Masukkan Nomor Kartu Vaksin: ");
                vaccinationCardNumber = Console.ReadLine();
                Console.Write("Masukkan NIK: ");
                nik = Console.ReadLine();
                Console.Write("Masukkan Nomor Telepon: ");
                phoneNumber = Console.ReadLine();
                Console.Write("Masukkan Nomor Kartu: ");
                cardNumber = Console.ReadLine();
            }
        }
    }
}