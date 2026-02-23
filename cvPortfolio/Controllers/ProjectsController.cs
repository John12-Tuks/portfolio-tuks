using Microsoft.AspNetCore.Mvc;
using MyWebsite.Models;

namespace MyWebsite.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Project()
        {
            var projects = new List<Project>
            {
                new Project
                {
                    ImagePath = "/images/projects/port-scanner.jpg",
                    Title = "PortScanner",
                    Description = "A lightweight and educational TCP Port Scanner built in Java that identifies open ports on a target host.",
                    GithubLink = "https://github.com/John12-Tuks/Java-portScanner"
                },
                new Project
                {
                    ImagePath = "/images/projects/diamond.jfif",
                    Title = "Minecraft Diamond Scanner(In Progress)",
                    Description = "Java-based tool that scans Minecraft .mca region files to locate diamonds and selected blocks.",
                    GithubLink = "https://github.com/John12-Tuks/MinecraftItemandBlockscanner.git"
                },
                new Project
                {
                    ImagePath = "/images/projects/shell.jfif",
                    Title = "PersonalShell(In Progress)",
                    Description = "A custom-built shell application designed to execute system commands and simulate terminal behavior.",
                    GithubLink = "https://github.com/John12-Tuks/PersonalShell.git"
                },
                new Project
                {
                    ImagePath = "/images/projects/AbcRetailors.png",
                    Title = "AbcRetailorsWebApp",
                    Description = "Retail Management Dashboard built with ASP.NET Core MVC to manage customers, products, and orders.",
                    GithubLink = "https://github.com/KgomoTokelo/AbcRetailorsWebAppPOE.git"
                },
                new Project
                {
                    ImagePath = "/images/projects/lecturer.png",
                    Title = "ContractMonthlyClaimsSystem",
                    Description = "Web application allowing lecturers to submit and track claims verified by coordinators and HR.",
                    GithubLink = "https://github.com/KgomoTokelo/PROG6212POE-PART-3-ContractMonthlyClaimsSystem.git"
                },
                new Project
                {
                    ImagePath = "/images/projects/chatbot.jfif",
                    Title = "CyberBot - Cybersecurity Chatbot",
                    Description = "C# chatbot with NLP intent detection, sentiment analysis, quiz logic, task reminders and cybersecurity guidance.",
                    GithubLink = "https://github.com/KgomoTokelo/ST10452012_PROG6221-POEPART1.git"
                },
                 new Project
                {
                    ImagePath = "/images/projects/homelab2.jfif",
                    Title = "HomeLab - Cybersecurity Homelab",
                    Description = "Designed and maintained a personal cybersecurity and software development lab for hands-on learning and experimentation. ",
                    },
                     new Project
                {
                    ImagePath = "/images/projects/dns.jfif",
                    Title = "Custom DNS Server for Bug Bounty & Private Resolution (In Progress)",
                    Description = "Building a custom DNS server on Ubuntu Server 22.04 designed for private DNS resolution and security monitoring. The current setup includes isolated CoreDNS instances and dedicated zones for controlled domain management.",
                    }
            };

            return View(projects);
        }
    }
}