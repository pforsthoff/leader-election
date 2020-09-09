using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace LeaderElection
{
    class Program
    {
        static void Main(string[] args)
        {
            var electionService = new LeaderElectionService();
            electionService.Start();
            Console.ReadLine();
        }
       
    }
}
