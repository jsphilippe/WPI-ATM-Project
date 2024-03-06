using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Net.Mail;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Org.BouncyCastle.Bcpg;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Mysqlx.Expect.Open.Types.Condition.Types;
using static WPI;

public class WPI
{
    public class WPIATM
    {
        public static void Main()
        {
            IRoleSelect roleselect = new RoleSelect();
            roleselect.roleSelect();
        }
    }
    private class RoleSelect : IRoleSelect
    {
        private string roleselect0 = string.Empty;
        private string roleselect1 = string.Empty;
        private int roleselect2;
        private int roleselect3;
        void IRoleSelect.roleSelect()
        {
            do
            {
                IMainMenu mainmenu = new MainMenu();
                mainmenu.mainMenu();
                roleselect0 = Console.ReadLine();
                bool result0 = int.TryParse(roleselect0, out roleselect2);
                if (roleselect2 == 1 | roleselect2 == 2)
                {
                        ISubMenuQuestion submenuquestion = new SubMenuQuestion();
                        submenuquestion.subMenuQuestion(roleselect2);
                        ISubMenu submenu = new SubMenu();
                        submenu.subMenu();
                        roleselect1 = Console.ReadLine();
                        bool result1 = int.TryParse(roleselect1, out roleselect3);
                }
                else if (roleselect2 == 3)
                {
                    IExitConsole exitconsole = new ExitConsole();
                    exitconsole.exitConsole();
                }
                else
                {
                    IRoleSelect roleselect = new RoleSelect();
                    roleselect.roleSelect();
                }
            }
            while (roleselect3 != 1 && roleselect3 == 2);
            IAuthenticateUser authenticateuser = new AuthenticateUser();
            authenticateuser.authenticateUser(roleselect2);
        }
    }
    public interface IRoleSelect
    {
        public void roleSelect();
    }
    private class ChangeBackgroundColor : IChangeBackgroundColor
    {
        void IChangeBackgroundColor.Black()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
        }
        void IChangeBackgroundColor.DarkBlue()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
        }
        void IChangeBackgroundColor.DarkGreen()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
        }
    }
    public interface IChangeBackgroundColor
    {
        public void Black();
        public void DarkBlue();
        public void DarkGreen();
    }
    private class MainMenu : IMainMenu
    {
        private List<string> mainmenu = new List<string>
    {
        "WPI-ATM Menu",
        "1 - Administrator",
        "2 - Customer",
        "3 - Exit"
    };
        void IMainMenu.mainMenu()
        {
            IChangeBackgroundColor changebackgroundcolor = new ChangeBackgroundColor();
            changebackgroundcolor.Black();
            IMenuHeader menuheader = new MenuHeader();
            menuheader.subMenuHeader();
            mainmenu.ForEach(i => Console.Write("{0}\n", i));
        }
    }
    public interface IMainMenu
    {
        public void mainMenu();
    }
    private class SubMenu : ISubMenu
    {
        private List<string> submenu = new List<string>
        {
            "1 - Yes",
            "2 - No"
        };
        void ISubMenu.subMenu()
        {
            IMenuHeader menuheader = new MenuHeader();
            menuheader.subMenuHeader();
            submenu.ForEach(i => Console.Write("{0}\n", i));
        }
    }
    public interface ISubMenu
    {
        void subMenu();
    }
    private class SubMenuQuestion : ISubMenuQuestion
    {
        private List<string> submenuquestion0 = new List<string>
        {
            "You selected option ",
            "\nIs this correct?"
        };
        void ISubMenuQuestion.subMenuQuestion(int submenuquestion1)
        {
            Console.WriteLine(submenuquestion0[0] + submenuquestion1
                              + submenuquestion0[1]);
        }
    }
    public interface ISubMenuQuestion
    {
        public void subMenuQuestion(int submenuquestion);
    }
    private class MenuHeader : IMenuHeader
    {
        private string submenuheader = "Please input a selection and press the ENTER Key:";
        void IMenuHeader.subMenuHeader()
        {
            Console.WriteLine(submenuheader);
        }
    }
    public interface IMenuHeader
    {
        public void subMenuHeader();
    }
    private class AdministratorMenu : IAdministratorMenu
    {
        private List<string> administratormenu = new List<string>
    {
        "WPI - Administrator Menu",
        "1 - Open new customer account",
        "2 - View customer account information",
        "3 - Modify customer account iformation",
        "4 - Delete customer account",
        "5 - Return to previous menu",
        "6 - Exit"
    };
        void IAdministratorMenu.administratorMenu()
        {
            IChangeBackgroundColor changebackgroundcolor = new ChangeBackgroundColor();
            changebackgroundcolor.DarkBlue();
            IMenuHeader menuheader = new MenuHeader();
            menuheader.subMenuHeader();
            administratormenu.ForEach(i => Console.Write("{0}\n", i));
        }
    }
    public interface IAdministratorMenu
    {
        public void administratorMenu();
    }
    private class CustomerMenu : ICustomerMenu
    {
        private List<string> customermenu = new List<string>
    {
        "WPI - Customer Menu",
        "1 - View my account information",
        "2 - Deposit cash",
        "3 - Withdraw cash",
        "5 - Return to previous menu",
        "6 - Exit"
    };
        void ICustomerMenu.customerMenu()
        {
            IChangeBackgroundColor changebackgroundcolor = new ChangeBackgroundColor();
            changebackgroundcolor.DarkGreen();
            IMenuHeader menuheader = new MenuHeader();
            menuheader.subMenuHeader();
            customermenu.ForEach(i => Console.Write("{0}\n", i));
        }
    }
    public interface ICustomerMenu
    {
        public void customerMenu();
    }
    private class AdministratorSelect : IAdministratorSelect
    {
        private string administratorselect0 = string.Empty;
        private string administratorselect1 = string.Empty;
        private int administratorselect2;
        private int administratorselect3;
        void IAdministratorSelect.administratorSelect()
        {
            IAdministratorMenu administratormenu = new AdministratorMenu();
            administratormenu.administratorMenu();
            administratorselect0 = Console.ReadLine();
            bool result0 = int.TryParse(administratorselect0, out administratorselect2);
            ISubMenuQuestion submenuquestion = new SubMenuQuestion();
            submenuquestion.subMenuQuestion(administratorselect2);
            ISubMenu submenu = new SubMenu();
            submenu.subMenu();
            administratorselect1 = Console.ReadLine();
            bool result1 = int.TryParse(administratorselect1, out administratorselect3);
            if (administratorselect2 == 1 && administratorselect3 == 1)
            {
                IAddCustomerAccount addcustomeraccount = new AddCustomerAccount();
                addcustomeraccount.addCustomerAccount();
            }
            else if (administratorselect2 == 2 && administratorselect3 == 1)
            {
                IViewCustomerAccount viewcustomeraccount = new ViewCustomerAccount();
                viewcustomeraccount.viewCustomerAccount();
            }
            else if (administratorselect2 == 3 && administratorselect3 == 1)
            {
                IModifyCustomerAccount modifycustomeraccount = new ModifyCustomerAccount();
                modifycustomeraccount.modifyCustomerAccount();
            }
            else if (administratorselect2 == 4 && administratorselect3 == 1)
            {
                IDeleteCustomerAccount deletecustomeraccount = new DeleteCustomerAccount();
                deletecustomeraccount.deleteCustomerAccount();
            }
            else if (administratorselect2 == 5 && administratorselect3 == 1)
            {
                IRoleSelect roleselect = new RoleSelect();
                roleselect.roleSelect();
            }
            else if (administratorselect2 == 6 && administratorselect3 == 1)
            {
                IExitConsole exitconsole = new ExitConsole();
                exitconsole.exitConsole();
            }
            else
            {
                IAdministratorSelect administratorselect = new AdministratorSelect();
                administratorselect.administratorSelect();
            }
        }
    }
    public interface IAdministratorSelect
    {
        public void administratorSelect();
    }
    private class CustomerSelect : ICustomerSelect
    {
        private string customerselect0 = string.Empty;
        private string customerselect1 = string.Empty;
        private string customerselect2 = string.Empty;
        private string customerselect3 = string.Empty;
        private string customerselect4 = "SELECT * FROM wpiatmdb.customers WHERE userid = '";
        private int customerselect5;
        private List<string> customerselect6 = new List<string>
        {
            "Please input an amount between $50.00 and $10,000 to deposit:",
            "Please input an amount between $50.00 and $1000.00 to withdraw",
            "UPDATE wpiatmdb.customers SET startingbalance = '",
            "'",
            " WHERE userid = '",
            ";"
        };
        private int customerselect7;
        private string customerselect8 = string.Empty;
        private int customerselect9;
        void ICustomerSelect.customerSelect(string userid)
        {
            customerselect4 = customerselect4 + userid + "';";
            ICustomerMenu customermenu = new CustomerMenu();
            customermenu.customerMenu();
            customerselect0 = Console.ReadLine();
            bool result0 = int.TryParse(customerselect0, out customerselect5);

            if (customerselect5 == 1)
            {
                IDBDetails idbdetails = new DBDetails();
                idbdetails.viewCustomerAccount(1, customerselect4);
            }
            else if (customerselect5 == 2)
            {
                Console.WriteLine(customerselect6[0]);
                customerselect1 = Console.ReadLine();
                bool result1 = int.TryParse(customerselect1, out customerselect5);
                if (customerselect5 > 0)
                {
                    customerselect5 = customerselect5;
                }
                else
                {
                    ICustomerSelect customerselect = new CustomerSelect();
                    customerselect.customerSelect(userid);
                }
                IDBDetails idbdetails = new DBDetails();
                idbdetails.adjustCustomerBalance(customerselect2);
            }
            else if (customerselect5 == 3)
            {
                Console.WriteLine(customerselect6[1]);
                customerselect2 = Console.ReadLine();
                bool result1 = int.TryParse(customerselect2, out customerselect5);
                if (customerselect5 > 0)
                {
                    customerselect5 = customerselect5 * -1;
                }
                else
                {
                    ICustomerSelect customerselect = new CustomerSelect();
                    customerselect.customerSelect(userid);
                }
                IDBDetails idbdetails = new DBDetails();
                idbdetails.adjustCustomerBalance(customerselect4);
            }
            else if (customerselect5 == 4)
            {
                ICustomerSelect customerselect  = new CustomerSelect();
                customerselect.customerSelect(userid);
            }
            else if (customerselect5 == 5)
            {
                IRoleSelect roleselect = new RoleSelect();
                roleselect.roleSelect();
            }
            else if (customerselect5 == 6)
            {
                IExitConsole exitconsole = new ExitConsole();
                exitconsole.exitConsole();
            }
        }
        void ICustomerSelect.customerSelect0(string userid, string sugardaddy)
        {
            customerselect9 = int.Parse(sugardaddy);
            customerselect7 = customerselect5 + customerselect9;
            customerselect4 = customerselect6[2] + customerselect7
                              + customerselect6[3] + customerselect6[4] + userid
                              + customerselect6[3] + customerselect6[5];
            Console.WriteLine(customerselect7 + customerselect4);
            IDBDetails idbdetails = new DBDetails();
            Console.WriteLine(customerselect7 + "This" + customerselect7 + "this" + customerselect4);
            idbdetails.adjustCustomerBalance(customerselect4);
        }
    }
    public interface ICustomerSelect
    {
        public void customerSelect(string userid);
        public void customerSelect0(string userid, string sugardaddy);
    }
    private class AuthenticateUser : IAuthenticateUser
    {
        private string userid = string.Empty;
        private string userpin = string.Empty;
        private string authenticateuser0 = string.Empty;
        private string authenticateuser1 = string.Empty;
        private List<string> authenticateuser2 = new List<string>
    {
        "SELECT usertype, userid, userpin FROM wpiatmdb.",
        " WHERE userid = '",
        " AND userPIN = '"
    };
        void IAuthenticateUser.authenticateUser(int roleselectinteger0)
        {
            Console.WriteLine("Please enter your userID and press the Enter key:");
            userid = Console.ReadLine();
            Console.WriteLine("Please enter your usePIN and press the Enter key:");
            userpin = Console.ReadLine();
            if(roleselectinteger0 == 1)
            {
                authenticateuser0 = "administrators";
            }
            else
            {
                authenticateuser0 = "customers";
            }
            authenticateuser1 = authenticateuser2[0] + authenticateuser0
                                    + authenticateuser2[1] + userid + "\'"
                                    + authenticateuser2[2] + userpin + "\';";
            IDBDetails dbdetails = new DBDetails();
            dbdetails.authenticateUser(userid, userpin, authenticateuser1);
        }
    }
    public interface IAuthenticateUser
    {
        public void authenticateUser(int roleselectinteger0);
    }
    private class AddCustomerAccount : IAddCustomerAccount
    {
        private string addcustomeraccount0 = string.Empty;
        private string addcustomeraccount1 = string.Empty;
        private string addcustomeraccount2 = string.Empty;
        private string addcustomeraccount4 = string.Empty;
        private int addcustomeraccount5;
        private int addcustomeraccount7;
        private List<string> addcustomeraccount8 = new List<string>
        {
            "INSERT INTO wpiatmdb.customers (usertype, userid, userpin, holdingcompany, "
            + "startingbalance, transactioninfo, userstatus) VALUES ('Customer', '",
            " 'Active');",
            "Please input the new customer's userID and press the ENTER key:",
            "Please input the new customer's bank holding company  and press the ENTER key:",
            "Please input the new customer's starting balance between $1.00 to $25000.00  and press the ENTER key:",
            "',",
            " '",
            "Account opened on "
        };
        void IAddCustomerAccount.addCustomerAccount()
        {
            Console.WriteLine(addcustomeraccount8[2]);
            addcustomeraccount0 = Console.ReadLine();
            Console.WriteLine(addcustomeraccount8[3]);
            addcustomeraccount1 = Console.ReadLine();
            do
            {
                Console.WriteLine(addcustomeraccount8[4]);
                addcustomeraccount2 = Console.ReadLine();
                bool result = int.TryParse(addcustomeraccount2, out addcustomeraccount5);
            }
            while (1 > addcustomeraccount5 && addcustomeraccount5 > 25000);
            Random addcustomeraccount6 = new Random();
            addcustomeraccount7 = addcustomeraccount6.Next(10000, 100000);
            addcustomeraccount4 = addcustomeraccount8[0] + addcustomeraccount0 + addcustomeraccount8[5]
                                  + addcustomeraccount8[6] + addcustomeraccount7 + addcustomeraccount8[5]
                                  + addcustomeraccount8[6] + addcustomeraccount1 + addcustomeraccount8[5]
                                  + addcustomeraccount8[6] + addcustomeraccount2 + addcustomeraccount8[5]
                                  + addcustomeraccount8[6] + addcustomeraccount8[7] + DateTime.Now
                                  + addcustomeraccount8[5] + addcustomeraccount8[1];
            IDBDetails dbdetails = new DBDetails();
            dbdetails.addCustomerAccount(addcustomeraccount4);
        }
    }
    public interface IAddCustomerAccount
    {
        void addCustomerAccount();
    }
    private class ViewCustomerAccount : IViewCustomerAccount
    {
        private string viewcustomeraccount0 = string.Empty;
        private string viewcustomeraccount1 = string.Empty;
        private int viewcustomeraccount2;
        private List<string> viewcustomeraccount3 = new List<string>
        {
            "SELECT * FROM wpiatmdb.customers WHERE accountnumber = ",
            "SELECT * FROM wpiatmdb.customers WHERE userid = '",
            "What is the customer's account number?",
            "What is the customer's userID?",
            "'",
            ";"
        };
        void IViewCustomerAccount.viewCustomerAccount()
        {
            IModifyCustomerAccountSubMenu modifycustomeraccountsubmenu = new ModifyCustomerAccountSubMenu();
            modifycustomeraccountsubmenu.modifyCustomerAccountSubMenu1();
            viewcustomeraccount0 = Console.ReadLine();
            bool result0 = int.TryParse(viewcustomeraccount0, out viewcustomeraccount2);
            if (viewcustomeraccount2 == 1)
            {
                Console.WriteLine(viewcustomeraccount3[2]);
                viewcustomeraccount0 = Console.ReadLine();
                bool result1 = int.TryParse(viewcustomeraccount0, out viewcustomeraccount2);
                viewcustomeraccount1 = viewcustomeraccount3[0] + viewcustomeraccount2 + viewcustomeraccount3[5];
                IDBDetails dbdetails = new DBDetails();
                dbdetails.viewCustomerAccount(0, viewcustomeraccount1);
            }
            else if (viewcustomeraccount2 == 2)
            {
                Console.WriteLine(viewcustomeraccount3[3]);
                viewcustomeraccount0 = Console.ReadLine();
                viewcustomeraccount1 = viewcustomeraccount3[1] + viewcustomeraccount0 + viewcustomeraccount3[4]
                                       + viewcustomeraccount3[5];
                IDBDetails dbdetails = new DBDetails();
                dbdetails.viewCustomerAccount(0, viewcustomeraccount1);
            }
            else 
            {
                IViewCustomerAccount viewcustomeraccount = new ViewCustomerAccount();
                viewcustomeraccount.viewCustomerAccount();
            }
        }
    }
    public interface IViewCustomerAccount
    {
        public void viewCustomerAccount();
    }
    private class ModifyCustomerAccount : IModifyCustomerAccount
    {
        private string modifycustomeraccount0 = string.Empty;
        private string modifycustomeraccount1 = string.Empty;
        private string modifycustomeraccount2 = string.Empty;
        private string modifycustomeraccount3 = string.Empty;
        private string modifycustomeraccount4 = string.Empty;
        private string modifycustomeraccount5 = string.Empty;
        private string modifycustomeraccount6 = string.Empty;
        private string modifycustomeraccount7 = string.Empty;
        private string modifycustomeraccount8 = string.Empty;
        private string modifycustomeraccount8a = string.Empty;
        private int modifycustomeraccount9;
        private int modifycustomeraccount10;
        private int modifycustomeraccount11;
        private int modifycustomeraccount12;
        private int modifycustomeraccount14;
        private List<string> modifycustomeraccount13 = new List<string>
        {
            "UPDATE wpiatmdb.customers SET ",
            "userid = '",
            "userpin = '",
            "holdingcompany = '",
            "userstatus = '",
            ", transactioninfo = '",
            "WHERE accountnumber = ",
            "'",
            ";",
            "Please input the customer's account number and press the ENTER key:",
            "Please input the customer's new userID and press the ENTER key:",
            "Do you want to reset the customer's userPIN?",
            "Please input the customer's new holding company and press the ENTER key:",
            "\nPlease input the customer's new account status:",
            "\nPlease Input an option and press the ENTER key",
            "\n1 - Active",
            "\n2 - Disabled",
            "\n1 - Yes",
            "\n2 - No",
            "Account status update on ",
            "UserID update on ",
            "UserPIN reset on ",
            "Holding company update on "
        };
        void IModifyCustomerAccount.modifyCustomerAccount()
        {
            IModifyCustomerAccountSubMenu modifycustomeraccountsubmenu0 = new ModifyCustomerAccountSubMenu();
            modifycustomeraccountsubmenu0.modifyCustomerAccountSubMenu0();
            modifycustomeraccount0 = Console.ReadLine();
            bool result0 = int.TryParse(modifycustomeraccount0, out modifycustomeraccount9);
            Console.WriteLine(modifycustomeraccount13[9]);
            modifycustomeraccount1 = Console.ReadLine();
            bool result1 = int.TryParse(modifycustomeraccount1, out modifycustomeraccount10);
            if (modifycustomeraccount9 == 1)
            {
                Console.WriteLine(modifycustomeraccount13[13] + modifycustomeraccount13[14]
                                  + modifycustomeraccount13[15] + modifycustomeraccount13[16]);
                modifycustomeraccount2 = Console.ReadLine();
                bool result2 = int.TryParse(modifycustomeraccount2, out modifycustomeraccount11);
                do
                {
                    if (modifycustomeraccount11 == 1)
                    {
                        modifycustomeraccount3 = "Active";
                    }
                    else if (modifycustomeraccount11 == 2)
                    {
                        modifycustomeraccount3 = "Disabled";
                    }
                }
                while (modifycustomeraccount11 != 1 && modifycustomeraccount11 != 2);
                modifycustomeraccount3 = modifycustomeraccount13[0] + modifycustomeraccount13[4]
                                         + modifycustomeraccount3 + modifycustomeraccount13[7]
                                         + modifycustomeraccount13[5] + modifycustomeraccount13[19]
                                         + DateTime.Now + modifycustomeraccount13[7]
                                         + modifycustomeraccount13[6] + modifycustomeraccount10
                                         + modifycustomeraccount13[8];
                IDBDetails dbdetails = new DBDetails();
                dbdetails.addCustomerAccount(modifycustomeraccount3);
            }
            else if (modifycustomeraccount9 == 2)
            {
                Console.WriteLine(modifycustomeraccount13[10]);
                modifycustomeraccount2 = Console.ReadLine();
                modifycustomeraccount3 = modifycustomeraccount13[0] + modifycustomeraccount13[1]
                                         + modifycustomeraccount2 + modifycustomeraccount13[7]
                                         + modifycustomeraccount13[5] + modifycustomeraccount13[20]
                                         + DateTime.Now + modifycustomeraccount13[7]
                                         + modifycustomeraccount13[6] + modifycustomeraccount10
                                         + modifycustomeraccount13[8];
                IDBDetails dbdetails = new DBDetails();
                dbdetails.addCustomerAccount(modifycustomeraccount3);
            }
            else if (modifycustomeraccount9 == 3)
            {
                Console.WriteLine(modifycustomeraccount13[11] + modifycustomeraccount13[14]
                                  + modifycustomeraccount13[17] + modifycustomeraccount13[18]);
                modifycustomeraccount2 = Console.ReadLine();
                bool result2 = int.TryParse(modifycustomeraccount2, out modifycustomeraccount11);
                do
                {
                    if (modifycustomeraccount11 == 1)
                    {
                        Random modifycustomeraccount12 = new Random();
                        modifycustomeraccount14 = modifycustomeraccount12.Next(10000, 100000);
                    }
                    else if (modifycustomeraccount11 == 2)
                    {
                        modifycustomeraccount3 = "Disabled";
                    }
                }
                while (modifycustomeraccount11 != 1 && modifycustomeraccount11 != 2);
                modifycustomeraccount3 = modifycustomeraccount13[0] + modifycustomeraccount13[2]
                                         + modifycustomeraccount14 + modifycustomeraccount13[7]
                                         + modifycustomeraccount13[5] + modifycustomeraccount13[21]
                                         + DateTime.Now + modifycustomeraccount13[7]
                                         + modifycustomeraccount13[6] + modifycustomeraccount10
                                         + modifycustomeraccount13[8];
                IDBDetails dbdetails = new DBDetails();
                dbdetails.addCustomerAccount(modifycustomeraccount3);
            }
            else if (modifycustomeraccount9 == 4)
            {
                Console.WriteLine(modifycustomeraccount13[12]);
                modifycustomeraccount2 = Console.ReadLine();
                bool result2 = int.TryParse(modifycustomeraccount2, out modifycustomeraccount11);
                modifycustomeraccount3 = modifycustomeraccount13[0] + modifycustomeraccount13[1]
                                         + modifycustomeraccount2 + modifycustomeraccount13[7]
                                         + modifycustomeraccount13[5] + modifycustomeraccount13[22]
                                         + DateTime.Now + modifycustomeraccount13[7]
                                         + modifycustomeraccount13[6] + modifycustomeraccount10
                                         + modifycustomeraccount13[8];
                IDBDetails dbdetails = new DBDetails();
                dbdetails.addCustomerAccount(modifycustomeraccount3);
            }
            else if (modifycustomeraccount9 == 5)
            {
                IAdministratorSelect administratorselect = new AdministratorSelect();
                administratorselect.administratorSelect();
            }
            else if (modifycustomeraccount12 == 6)
            {
                IExitConsole exitconsole = new ExitConsole();
                exitconsole.exitConsole();
            }
            else
            {
                IModifyCustomerAccount modifycustomeraccount = new ModifyCustomerAccount();
                modifycustomeraccount.modifyCustomerAccount();
            }
            IDBDetails addcustomeraccount = new DBDetails();
            addcustomeraccount.addCustomerAccount(modifycustomeraccount8);
        }

    }
    public interface IModifyCustomerAccount
    {
        public void modifyCustomerAccount();
    }
    private class ModifyCustomerAccountSubMenu : IModifyCustomerAccountSubMenu
    {
        private List<string> modifycustomeraccountsubmenu0 = new List<string>
        {
            "WPI-ATM Customer Account Update Submenu",
            "Please input an option and press the ENTER key:",
            "1 - Update Account Status",
            "2 - Update UserID",
            "3 - Reset UserPIN",
            "4 - Update Holding Company",
            "5 - Return to previous menu",
            "6 - Exit"
        };
        private List<string> modifycustomeraccountsubmenu1 = new List<string>
        {
            "Do you want to you want to use the customer's account number or userID?",
            "Please input a selection and press the ENTER Key:",
            "1 - Use the customer's account number",
            "2 - Use the cusomer's userID",
        };
        void IModifyCustomerAccountSubMenu.modifyCustomerAccountSubMenu0()
        {
            modifycustomeraccountsubmenu0.ForEach(i => Console.Write("{0}\n", i));
        }
        void IModifyCustomerAccountSubMenu.modifyCustomerAccountSubMenu1()
        {
            modifycustomeraccountsubmenu1.ForEach(i => Console.Write("{0}\n", i));
        }
    }
    public interface IModifyCustomerAccountSubMenu
    {
        public void modifyCustomerAccountSubMenu0();
        public void modifyCustomerAccountSubMenu1();
    }
    private class DeleteCustomerAccount : IDeleteCustomerAccount
    {
        private string deletecustomeraccount0 = string.Empty;
        private string deletecustomeraccount1 = string.Empty;
        private int deletecustomeraccount2;
        private List<string> deletecustomeraccount3 = new List<string>
        { "DELETE FROM wpiatmdb.customers WHERE accountnumber = ",
          "DELETE FROM wpiatmdb.customers WHERE userid = '",
          "'",
          ";",
          "What is the customer's account number?",
          "What is the customer's userID?"
        };
        void IDeleteCustomerAccount.deleteCustomerAccount()
        {
            IModifyCustomerAccountSubMenu modifycustomeraccountsubmenu = new ModifyCustomerAccountSubMenu();
            modifycustomeraccountsubmenu.modifyCustomerAccountSubMenu1();
            deletecustomeraccount0 = Console.ReadLine();
            bool result0 = int.TryParse(deletecustomeraccount0, out deletecustomeraccount2);
            if (deletecustomeraccount2 == 1) 
            {
                Console.WriteLine(deletecustomeraccount3[4]);
                deletecustomeraccount1 = Console.ReadLine();
                deletecustomeraccount1 = deletecustomeraccount3[0] + deletecustomeraccount1
                                         + deletecustomeraccount3[3];
                IDBDetails idbdetails = new DBDetails();
                idbdetails.addCustomerAccount(deletecustomeraccount1);
            }
            else if (deletecustomeraccount2 == 2)
            {
                Console.WriteLine(deletecustomeraccount3[5]);
                deletecustomeraccount1 = Console.ReadLine();
                deletecustomeraccount1 = deletecustomeraccount3[1] + deletecustomeraccount1
                                         + deletecustomeraccount3[2] + deletecustomeraccount3[3];
                IDBDetails idbdetails = new DBDetails();
                idbdetails.addCustomerAccount(deletecustomeraccount1);
            }
            else 
            {
                IDeleteCustomerAccount deletecustomeraccount = new DeleteCustomerAccount();
                deletecustomeraccount.deleteCustomerAccount();
            }
        }
    }
    public interface IDeleteCustomerAccount
    {
        public void deleteCustomerAccount();
    }
    private class DBDetails : IDBDetails
    {
        private string dbdetailsstring0 = "localhost";
        private string dbdetailsstring1 = "root";
        private string dbdetailsstring2 = "\"9Q&lt;td4U4ed6TA\"";
        private string dbdetailsstring3 = "wpiatmdb";
        void IDBDetails.authenticateUser(string userid, string userpin, string authenticateuserquery)
        {
            IReadDBData readdbdata = new ReadDBData();
            readdbdata.authenticateUser(userid, userpin, authenticateuserquery, dbdetailsstring0,
                                        dbdetailsstring1, dbdetailsstring2, dbdetailsstring3);
        }
        void IDBDetails.viewCustomerAccount(int usertype, string viewcustomeraccountquery)
        {
            IReadDBData readdbdata = new ReadDBData();
            readdbdata.viewCustomerAccount(usertype, viewcustomeraccountquery, dbdetailsstring0,
                                        dbdetailsstring1, dbdetailsstring2, dbdetailsstring3);
        }
        void IDBDetails.addCustomerAccount(string addcustomeraccountquery)
        {
            IModifyDBData modifydbdata = new ModifyDBData();
            modifydbdata.modifyDBData(addcustomeraccountquery, dbdetailsstring0, dbdetailsstring1,
                                      dbdetailsstring2, dbdetailsstring3);
        }
        void IDBDetails.adjustCustomerBalance(string adjustcustomerbalance)
        {
            IModifyDBData modifydbdata = new ModifyDBData();
            modifydbdata.modifyDBData0(adjustcustomerbalance, dbdetailsstring0, dbdetailsstring1,
                                      dbdetailsstring2, dbdetailsstring3);
        }
    }
    public interface IDBDetails
    {
        public void authenticateUser(string userid, string userpin,
                                     string authenticateuserquery);
        public void viewCustomerAccount(int usertype, string viewcustomeraccountquery);
        public void addCustomerAccount(string addcustomeraccountquery);
        public void adjustCustomerBalance(string adjustcustomerbalance);
    }
    private class ReadDBData : IReadDBData
    {
        private string readdbdata0 = string.Empty;
        private string readdbdata4 = string.Empty;
        private string readdbdata5 = string.Empty;
        private string readdbdata6 = string.Empty;
        private string readdbdata7 = string.Empty;
        private string readdbdata8 = string.Empty;
        private string readdbdata9 = string.Empty;
        private string readdbdata10 = string.Empty;
        private int readbdata11;
        private List<string> readdbdatastringlist = new List<string>()
        {
            "Customer Account Details",
            "\n1 - Account number: ",
            "\n2 - Status: ",
            "\n3 - UserID: ",
            "\n4 - UserPIN: ",
            "\n5 - Holding Company: ",
            "\n6 - Account Balance: $",
            "\n7 - Last transaction: ",
            "\nYou will return to the previous menu in 15 seconds."
    };
        void IReadDBData.authenticateUser(string userid, string userpin, string authenticateuserquery,
                                          string dbdetailsstring0, string dbdetailsstring1,
                                          string dbdetailsstring2, string dbdetailsstring3)
        {
            readdbdata0 = string.Format("server={0};uid={1};pwd={2};database={3};"
                         , dbdetailsstring0, dbdetailsstring1, dbdetailsstring2
                         , dbdetailsstring3);
            var readdbdata1 = new MySql.Data.MySqlClient.MySqlConnection(readdbdata0);
            var readdbdata2 = new MySql.Data.MySqlClient.MySqlCommand(authenticateuserquery,
                              readdbdata1);
            readdbdata1.Open();
            var readdbdata3 = readdbdata2.ExecuteReader();
            if (readdbdata3.Read() == true)
            {
                readdbdata4 = readdbdata3.GetString(0);
                readdbdata5 = readdbdata3.GetString(1);
                readdbdata6 = readdbdata3.GetString(2);
                if (readdbdata4 == "Administrator" && readdbdata5 == userid
                    && readdbdata6 == userpin)
                {
                    IAdministratorSelect administratorselect = new AdministratorSelect();
                    administratorselect.administratorSelect();
                }
                else if (readdbdata4 == "Customer" && readdbdata5 == userid
                         && readdbdata6 == userpin)
                {
                    ICustomerSelect customerselect = new CustomerSelect();
                    customerselect.customerSelect(userid);
                }
            }
            else
            {
                Console.WriteLine("There is no match for that userID and userPIN combination."
                                  + " Please try again." + "\nReturning to previous menu.");
                Thread.Sleep(3000);
                IRoleSelect roleselect = new RoleSelect();
                roleselect.roleSelect();
            }
            readdbdata1.Close();
        }
        void IReadDBData.viewCustomerAccount(int usertype, string viewCustomeraccountquery, string dbdetailsstring0,
                                             string dbdetailsstring1, string dbdetailsstring2,
                                             string dbdetailsstring3)
        {
            readdbdata0 = string.Format("server={0};uid={1};pwd={2};database={3};"
                         , dbdetailsstring0, dbdetailsstring1, dbdetailsstring2
                         , dbdetailsstring3);
            var readdbdata1 = new MySql.Data.MySqlClient.MySqlConnection(readdbdata0);
            var readdbdata2 = new MySql.Data.MySqlClient.MySqlCommand(viewCustomeraccountquery,
                              readdbdata1);
            readdbdata1.Open();
            var readdbdata3 = readdbdata2.ExecuteReader();
            if (readdbdata3.Read() == true)
            {
                readbdata11 = readdbdata3.GetInt32(6);
                readdbdata4 = readdbdata3.GetString(5);
                readdbdata5 = readdbdata3.GetString(0);
                readdbdata6 = readdbdata3.GetString(1);
                readdbdata7 = readdbdata3.GetString(2);
                readdbdata8 = readdbdata3.GetString(3);
                readdbdata9 = readdbdata3.GetString(4);
                readdbdata10 = readdbdata3.GetString(7);
                Console.WriteLine(readdbdatastringlist[0] + readdbdatastringlist[1] + readbdata11
                                  + readdbdatastringlist[2] + readdbdata4 + readdbdatastringlist[3]
                                  + readdbdata6 + readdbdatastringlist[4] + readdbdata7
                                  + readdbdatastringlist[5] + readdbdata8 + readdbdatastringlist[6]
                                  + readdbdata9 + readdbdatastringlist[7] + readdbdata10
                                  + readdbdatastringlist[8]);
                Thread.Sleep(15000);
                if (usertype == 0)
                {
                    IAdministratorSelect administratorselect = new AdministratorSelect();
                    administratorselect.administratorSelect();
                }
                else if (usertype == 2)
                {
                    ICustomerSelect customerselect = new CustomerSelect();
                    customerselect.customerSelect0(readdbdata6, readdbdata9);
                }
                else
                {
                    ICustomerSelect customerselect = new CustomerSelect();
                    customerselect.customerSelect(readdbdata6);
                    ICustomerSelect customerselect0 = new CustomerSelect();
                }
            }
            else
            {
                Console.WriteLine("There is no match for that account. Please try again."
                                  + "\nReturning to previous menu.");
                Thread.Sleep(3000);
                IRoleSelect roleselect = new RoleSelect();
                roleselect.roleSelect();
            }
            readdbdata1.Close();
        }
        void IReadDBData.viewMyAccount()
        {

        }
    }
    public interface IReadDBData
    {
        public void authenticateUser(string userid, string userpin, string authenticateuserquery,
                                     string dbdetailsstring0, string dbdetailsstring1,
                                     string dbdetailsstring2, string dbdetailsstring3);
        public void viewCustomerAccount(int usertype, string viewCustomeraccountquery,
                                        string dbdetailsstring0, string dbdetailsstring1,
                                        string dbdetailsstring2, string dbdetailsstring3);
        public void viewMyAccount();
    }
    private class ModifyDBData : IModifyDBData
    {
        private string modifydbdata4 = string.Empty;
        private string modifydbdata5 = string.Empty;
        void IModifyDBData.modifyDBData(string addcustomerquery, string modifydbdata0,
                                        string modifydbdata1, string modifydbdata2,
                                        string modifydbdata3)
        {
            modifydbdata4 = string.Format("server={0};uid={1};pwd={2};database={3};"
                           , modifydbdata0, modifydbdata1, modifydbdata2
                           , modifydbdata3);
            var modifydbdatavariable0 = new MySql.Data.MySqlClient.MySqlConnection(modifydbdata4);
            var modifydbdatavariable1 = new MySql.Data.MySqlClient.MySqlCommand(addcustomerquery,
                                        modifydbdatavariable0);
            try
            {
                modifydbdatavariable0.Open();
                modifydbdatavariable1.ExecuteNonQuery();
                Console.WriteLine("Transaction successfully executed!"
                                  + "\nReturning to the previous menu.");
                Thread.Sleep(3000);
                IAdministratorSelect administratorselect = new AdministratorSelect();
                administratorselect.administratorSelect();
            }
            catch (Exception modifydbdata5)
            {
                Console.WriteLine("The following error occurred: "
                                  + "\n" + modifydbdata5
                                  + "\nReturning to the previous menu.");
                Thread.Sleep(30000);
                IAdministratorSelect administratorselect = new AdministratorSelect();
                administratorselect.administratorSelect();
            }
        }
        void IModifyDBData.modifyDBData0(string addcustomerquery, string modifydbdata0,
                                       string modifydbdata1, string modifydbdata2,
                                       string modifydbdata3)
        {
            modifydbdata4 = string.Format("server={0};uid={1};pwd={2};database={3};"
                           , modifydbdata0, modifydbdata1, modifydbdata2
                           , modifydbdata3);
            var modifydbdatavariable0 = new MySql.Data.MySqlClient.MySqlConnection(modifydbdata4);
            var modifydbdatavariable1 = new MySql.Data.MySqlClient.MySqlCommand(addcustomerquery,
                                        modifydbdatavariable0);
            Console.WriteLine("Please enter your userID to validate your identity: ");
            modifydbdata5 = Console.ReadLine();
            try
            {
                modifydbdatavariable0.Open();
                modifydbdatavariable1.ExecuteNonQuery();
                Console.WriteLine("Transaction successfully executed!"
                                  + "\nReturning to the previous menu.");
                Thread.Sleep(3000);
                ICustomerSelect sustomerselect = new CustomerSelect();
                sustomerselect.customerSelect(modifydbdata5);
            }
            catch (Exception modifydbdata6)
            {
                Console.WriteLine("The following error occurred: "
                                  + "\n" + modifydbdata6
                                  + "\nReturning to the previous menu.");
                Thread.Sleep(30000);
                ICustomerSelect sustomerselect = new CustomerSelect();
                sustomerselect.customerSelect(modifydbdata5);
            }
        }
    }
    public interface IModifyDBData
    {
        public void modifyDBData(string addcustomerquery, string modifydbdata0, string modifydbdata1,
                          string modifydbdata2, string modifydbdata3);
        public void modifyDBData0(string addcustomerquery, string modifydbdata0, string modifydbdata1,
                          string modifydbdata2, string modifydbdata3);
    }
    private class ExitConsole : IExitConsole
    {
        private string exitconsole = "You elected to exit the console. We thank you for your time.";
        void IExitConsole.exitConsole()
        {
            Console.WriteLine(exitconsole);
            System.Environment.Exit(1);
        }
    }
    public interface IExitConsole
    {
        public void exitConsole();
    }
}