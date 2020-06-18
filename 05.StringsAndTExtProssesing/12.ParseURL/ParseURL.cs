using System;

//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.

//Input
//•On the only line you will receive an address

//Output
//•Print the protocol, server and resource as shown below

//Constraints
//•Time limit: 0.1s
//•Memory limit: 16MB

//Sample tests


//Input:http://telerikacademy.com/Courses/Courses/Details/212

//Output:[protocol] = http
//       [server] = telerikacademy.com
//       [resource] = /Courses/Courses/Details/212 


// 
//https://github.com/gentoo/gentoo.git 

//[protocol] = https
//[server] = github.com
//[resource] = /gentoo/gentoo.git


namespace _12.ParseURL
{
   class ParseURL
   {
      static void Main()
      {
         string url = Console.ReadLine();


         
         int indexOfProtocol = url.IndexOf("://"); //start index
         string protocol = url.Substring(0, indexOfProtocol); //from 0 to the start index

         int indexOfServer = url.IndexOf("/", indexOfProtocol + 3); //the start of the next index
         string server = url.Substring(indexOfProtocol + 3, indexOfServer - indexOfProtocol - 3); 

         string resource = url.Substring(indexOfServer);

         Console.WriteLine("[protocol] = {0}", protocol);
         Console.WriteLine("[server] = {0}", server);
         Console.WriteLine("[resource] = {0}", resource);

      }
   }
}
