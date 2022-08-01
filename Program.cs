using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace USDMSVersion01
{
    class Program
    {
        //****************** GLOBAL DATA STRUCTURE *****************
         const int length = 20; // lenght of arrays
        //****************** SECURITY-ARRAYS ******************
        static string[] firstname = new string[length]; // create an account store firstname
        static string[] lastname = new string[length]; // create an account store lastname
        static string[] username = new string[length]; // create an account store username
        static string[] password = new string[length]; // create an account store password
        static string[] firstname_Agent = new string[length]; // create an account store firstname
        static string[] lastname_Agent = new string[length]; // create an account store lastname
        static string[] username_Agent = new string[length]; // create an account store username
        static string[] password_Agent = new string[length]; // create an account store password
        //****************** ADMIN-ARRAYS ******************
        static string[] semesterType = new string[length]; // academic fee variables , opAdmin >> opAcademicFee
        static string[] challanNo = new string[length];
        static string[] date = new string[length];
        static string[] remarks = new string[length];
        static  float[] amountacademic = new float[length]; // academic fee variables , opAdmin >> opAcademicFee
        static string[] menuBreakfast = new string[length]; // meal breakfast charges , opHostel >> opMeal >> opMealBreakfast
        static string[] remarksBreakfast = new string[length];
        static  float[] chargesBreakfast = new float[length]; // meal breakfast charges , opHostel >> opMeal >> opMealBreakfast
        static string[] menuLunch = new string[length]; // meal lunch charges , opHostel >> opMeal >> opMealLunch
        static string[] remarksLunch = new string[length];
        static  float[] chargesLunch = new float[length]; // meal lunch charges , opHostel >> opMeal >> opMealLunch
        static string[] menuDinner = new string[length]; // meal dinner charges , opHostel >> opMeal >> opMealDinner
        static string[] remarksDinner = new string[length];
        static  float[] chargesDinner = new float[length]; // meal dinner charges , opHostel >> opMeal >> opMealDinner
        static string[] monthlyMealExpenses = new string[length]; // monthly meal charges , opHostel >> opMealCharges
        static string[] remarksMealExpenses = new string[length];
        static  float[] chargesMealMonthly = new float[length]; // monthly meal charges , opHostel >> opMealCharges
        static string[] monthLivingExpenses = new string[length]; // monthly living charges , opHostel >> opLivingCharges
        static string[] remarksLivingExpenses = new string[length];
        static  float[] chargesLivingExpenses = new float[length]; // monthly living charges , opHostel >> opLivingCharges
        static string[] monthServiceExpenses = new string[length]; // monthly service charges , opHostel >> opServiceCharges
        static string[] remarksServiceExpenses = new string[length];
        static  float[] chargesServiceMonthly = new float[length]; // monthly service charges , opHostel >> opServiceCharges
        static string[] remarksRenovationExpenses = new string[length]; // renovation charges , opHostel >> opRenovationCharges
        static  float[] chargesRenovationMonthly = new float[length]; // renovation charges , opHostel >> opRenovationCharges
        static string[] remarksLaundryExpenses = new string[length]; // laundry charges , opHostel >> opLaundryCharges
        static  float[] chargesLaundryMonthly = new float[length]; // laundry charges , opHostel >> opLaundryCharges
        static string[] remarksBarberExpenses = new string[length]; // barber charges , opHostel >> opBarberCharges
        static  float[] chargesBarberMonthly = new float[length]; // barber charges , opHostel >> opBarberCharges
        static string[] remarksNotesExpenses = new string[length]; // notes charges , opHelpingMaterial >> opNotesHelpingMaterial
        static  float[] chargesNotesMonthly = new float[length]; // notes charges , opHelpingMaterial >> opNotesHelpingMaterial
        static string[] remarksRegisterExpenses = new string[length]; // register charges , opHelpingMaterial >> opRegisterHelpingMaterial
        static  float[] chargesRegisterMonthly = new float[length]; // register charges , opHelpingMaterial >> opRegisterHelpingMaterial
        static string[] remarksStationaryExpenses = new string[length]; // stationary charges , opHelpingMaterial >> opStationaryHelpingMaterial
        static  float[] chargesStationaryMonthly = new float[length]; // stationary charges , opHelpingMaterial >> opStationaryHelpingMaterial
        static string[] remarksFriendsRecreationalExpenses = new string[length]; // friend recreational expenses , opRecreationalExpenses >> opFriendsRecreationalExpenses
        static  float[] chargesFriendsRecreationalExpenses = new float[length]; // friend recreational expenses , opRecreationalExpenses >> opFriendsRecreationalExpenses
        static string[] remarksFamilyRecreationalExpenses = new string[length]; // family recreational expenses , opRecreationalExpenses >> opFamilyRecreationalExpenses
        static  float[] chargesFamilyRecreationalExpenses = new float[length]; // family recreational expenses , opRecreationalExpenses >> opFamilyRecreationalExpenses
        static string[] remarksClassCommunityFund = new string[length]; // class community fund , opCommunityFund >> opClassCommunityFund
        static  float[] chargesClassCommunityFund = new float[length]; // class community fund , opCommunityFund >> opClassCommunityFund
        static string[] remarksSocietiesCommunityFund = new string[length]; // class community fund , opCommunityFund >> opSocietiesCommunityFund
        static  float[] chargesSocietiesCommunityFund = new float[length]; // class community fund , opCommunityFund >> opSocietiesCommunityFund
        static string[] titleDailyGoals = new string[length]; // daily goals , opGoals >> opDailyGoals
        static string[] descriptionDailyGoals = new string[length];
        static string[] titleWeeklyGoals = new string[length]; // weekly goals , opGoals >> opWeeklyGoals
        static string[] descriptionWeeklyGoals = new string[length];
        static string[] titleMonthlyGoals = new string[length]; // monthly goals , opGoals >> opMonthlyGoals
        static string[] descriptionMonthlyGoals = new string[length];
        static string[] titleYearlyGoals = new string[length]; // yearly goals , opGoals >> opYearlyGoals
        static string[] descriptionYearlyGoals = new string[length];
        static string[] nameCallPakage = new string[length]; // call package , opCellPhone >> opCall_CellPhone
        static  float[] amountCallPakage = new float[length]; // call pacage ,  opCellPhone >> opCall_CellPhone
        static string[] durationCallPakage = new string[length];//durationCallPakage
        static string[] nameInternetPakage = new string[length]; // internet package , opCellPhone >> opInternet_CellPhone
        static string[] durationInternetPakage = new string[length];
        static  float[] amountInternetPakage = new float[length]; // internet package , opCellPhone >> opInternet_CellPhone
        static string[] nameMessagePakage = new string[length]; // message package , opCellPhone >> opMessage_CellPhone
        static string[] durationMessagePakage = new string[length];
        static  float[] amountMessagePakage = new float[length]; // message package , opCellPhone >> opMessage_CellPhone
        static string[] titleBorrowBook = new string[length]; // borrow book , opBook >> opBookBorrow
        static string[] authorBorrowBook = new string[length];
        static string[] friendnameBorrowBook = new string[length];
        static string[] remarksBorrowBook = new string[length];
        static string[] titlePurchaseBook = new string[length]; // purchase book , opBook >> opBookPurchase
        static string[] authorPurchaseBook = new string[length];
        static string[] remarksPurchaseBook = new string[length];
        static  float[] amountPurchaseBook = new float[length]; // purchase book , opBook >> opBookPurchase
        static string[] five_time_Prayer = new string[length]; // five time prayer , opSelfMotivational >> opFiveTimePrayer
        static string[] Quran_e_Pak = new string[length]; // quran e pak , opSelfMotivational >> opQuran_e_Pak
        static string[] Durood_e_Pak = new string[length]; // durood e pak , opSelfMotivational >> opDurood_e_Pak
        static string[] locationFromUber = new string[length]; // transport uber/cream/bykea , opTransport >> opUberTransport
        static string[] locationToUber = new string[length];
        static string[] purposeUber = new string[length];
        static  float[] amountUber = new float[length]; // transport uber/cream/bykea , opTransport >> opUberTransport
        static string[] locationFromBus = new string[length]; // transport bus , opTransport >> opBusTransport
        static string[] locationToBus = new string[length];
        static string[] purposeBus = new string[length];
        static  float[] amountBus = new float[length]; // transport bus , opTransport >> opBusTransport
        static  float[] minutiesSporties = new float[length]; // sporties recreational activities , opRecreationalActivities >> opSportiesActivities
        static  float[] minutiesSocieties = new float[length]; // societies recreational activities , opRecreationalActivities >> opSocietiesActivities
        static string[] purposeSocieties = new string[length]; // societies recreational activities , opRecreationalActivities >> opSocietiesActivities
        static string[] awardCo_Curricular = new string[length]; // achievements co-curricular , opAchievements >> opCoCurricular
        static string[] presentCo_Curricular = new string[length];
        static string[] remarksCo_Curricular = new string[length];
        static string[] awardExtra_Curricular = new string[length]; //  achievements extra-curricular , opAchievements >> opExtraCurricular
        static string[] presentExtra_Curricular = new string[length];
        static string[] remarksExtra_Curricular = new string[length];
        static  float[] gpa = new float[length]; // result grades , opResultGrades
        static  float[] cgpa = new float[length];
        static string[] remarksResult = new string[length]; // result grades , opResultGrades
        static string[] titleGoldenLines = new string[length]; // golden lines , opGoldenLines
        static string[] descriptionGoldenLines = new string[length];
        static string[] titleLifelongEvents = new string[length]; // life long events , opLifelongEvents
        static string[] descriptionLifelongEvents = new string[length];
        static string[] titleNotes = new string[length]; // notes , opNotes
        static string[] descriptionNotes = new string[length];
        // ****************** INCREMENT-VARIABLES ******************
        static int inc_opAddUser = 0;                     // increment in the array index
        static int inc_opAgentAddUser = 0;                // increment in the array index
        static int increment_opAcademicFee = 0;           // increment in the array index
        static int increment_opMealBreakfast = 0;         // increment in the array index
        static int increment_opMealLunch = 0;             // increment in the array index
        static int increment_opMealDinner = 0;            // increment in the array index
        static int increment_opMealCharges = 0;           // increment in the array index
        static int inc_opLivingCharges = 0;               // increment in the array index
        static int inc_opServiceCharges = 0;              // increment in the array index
        static int inc_opRenovationCharges = 0;           // increment in the array index
        static int inc_opLaundryCharges = 0;              // increment in the array index
        static int inc_opBarberCharges = 0;               // increment in the array index
        static int inc_opNotesHelpingMaterial = 0;        // increment in the array index
        static int inc_opRegisterHelpingMaterial = 0;     // increment in the array index
        static int inc_opStationaryHelpingMaterial = 0;   // increment in the array index
        static int inc_opFriendsRecreationalExpenses = 0; // increment in the array index
        static int inc_opFamilyRecreationalExpenses = 0;  // increment in the array index
        static int inc_opClassCommunityFund = 0;          // increment in the array index
        static int inc_opSocietiesCommunityFund = 0;      // increment in the array index
        static int inc_opDailyGoals = 0;                  // increment in the array index
        static int inc_opWeeklyGoals = 0;                 // increment in the array index
        static int inc_opMonthlyGoals = 0;                // increment in the array index
        static int inc_opYearlyGoals = 0;                 // increment in the array index
        static int inc_opCall_CellPhone = 0;              // increment in the array index
        static int inc_opInternet_CellPhone = 0;          // increment in the array index
        static int inc_opMessage_CellPhone = 0;           // increment in the array index
        static int inc_opBookBorrow = 0;                  // increment in the array index
        static int inc_opBookPurchase = 0;                // increment in the array index
        static int inc_opFiveTimePrayer = 0;              // increment in the array index
        static int inc_opQuran_e_Pak = 0;                 // increment in the array index
        static int inc_opDurood_e_Pak = 0;                // increment in the array index
        static int inc_opUberTransport = 0;               // increment in the array index
        static int inc_opBusTransport = 0;                // increment in the array index
        static int inc_opSportiesActivities = 0;          // increment in the array index
        static int inc_opSocietiesActivities = 0;         // increment in the array index
        static int inc_opCoCurricular = 0;                // increment in the array index
        static int inc_opExtraCurricular = 0;             // increment in the array index
        static int inc_opResultGrades = 0;                // increment in the array index
        static int inc_opGoldenLines = 0;                 // increment in the array index
        static int inc_opLifelongEvents = 0;              // increment in the array index
        static int inc_opNotes = 0;                       // increment in the array index
        //****************** ADMIN & AGENT-VARIABLES ******************
        static float addWalletMoney = 0;   // this used to add money from agent and show in balance
        static string walletRemarks = " "; // this used to add remarks from agent and show in balance
        static void Main(string[] args)
        {
            load_adminSecurityFile();                        // file handling, load data from files into arrays and variables before running program
            load_agentSecurityFile();                        // file handling, load data from files into arrays and variables before running program
            load_agentWalletMoney();                         // file handling, load data from files into arrays and variables before running program
            load_admin3AcadmicFee();                         // file handling, load data from files into arrays and variables before running program
            load_admin_4Hostel_1Meal_1Breakfast();           // file handling, load data from files into arrays and variables before running program
            load_admin_4Hostel_1Meal_2Lunch();               // file handling, load data from files into arrays and variables before running program
            load_admin_4Hostel_1Meal_3Dinner();              // file handling, load data from files into arrays and variables before running program
            load_admin_4Hostel_2MealChargesMonthly();        // file handling, load data from files into arrays and variables before running program
            load_admin_4Hostel_3LivingChargesMonthly();      // file handling, load data from files into arrays and variables before running program
            load_admin_4Hostel_4ServiceChargesMonthly();     // file handling, load data from files into arrays and variables before running program
            load_admin_4Hostel_5RenovationChargesMonthly();  // file handling, load data from files into arrays and variables before running program
            load_admin_4Hostel_6LaundryChargesMonthly();     // file handling, load data from files into arrays and variables before running program
            load_admin_4Hostel_7BarberChargesMonthly();      // file handling, load data from files into arrays and variables before running program
            load_admin_5HelpingMaterial_1Notes();            // file handling, load data from files into arrays and variables before running program
            load_admin_5HelpingMaterial_2Register();         // file handling, load data from files into arrays and variables before running program
            load_admin_5HelpingMaterial_3Stationary();       // file handling, load data from files into arrays and variables before running program
            load_admin_6RecreationalExpenses_1Friends();     // file handling, load data from files into arrays and variables before running program
            load_admin_6RecreationalExpenses_2Family();      // file handling, load data from files into arrays and variables before running program
            load_admin_7CommunityFund_1Class();              // file handling, load data from files into arrays and variables before running program
            load_admin_7CommunityFund_2Societies();          // file handling, load data from files into arrays and variables before running program
            load_admin_8Goals_1Daily();                      // file handling, load data from files into arrays and variables before running program
            load_admin_8Goals_2Weekly();                     // file handling, load data from files into arrays and variables before running program
            load_admin_8Goals_3Monthly();                    // file handling, load data from files into arrays and variables before running program
            load_admin_8Goals_4Yearly();                     // file handling, load data from files into arrays and variables before running program
            load_admin_9CellPhone_1Call();                   // file handling, load data from files into arrays and variables before running program
            load_admin_9CellPhone_2Internet();               // file handling, load data from files into arrays and variables before running program
            load_admin_9CellPhone_3Message();                // file handling, load data from files into arrays and variables before running program
            load_admin_10Book_1Borrow();                     // file handling, load data from files into arrays and variables before running program
            load_admin_10Book_2Purchase();                   // file handling, load data from files into arrays and variables before running program
            load_admin_11SelfMotivational_1FiveTimePrayer(); // file handling, load data from files into arrays and variables before running program
            load_admin_11SelfMotivational_2Quran_e_Pak();    // file handling, load data from files into arrays and variables before running program
            load_admin_11SelfMotivational_3Durood_e_Pak();   // file handling, load data from files into arrays and variables before running program
            load_admin_12Transport_1Uber();                  // file handling, load data from files into arrays and variables before running program
            load_admin_12Transport_2Bus();                   // file handling, load data from files into arrays and variables before running program
            load_admin_13RecreationalActivities_1Sporties(); // file handling, load data from files into arrays and variables before running program
            load_admin_13RecreationalActivities_2Socities(); // file handling, load data from files into arrays and variables before running program
            load_admin_14Achievments_1CoCurricular();        // file handling, load data from files into arrays and variables before running program
            load_admin_14Achievments_2ExtraCurricular();     // file handling, load data from files into arrays and variables before running program
            load_admin_15ResultGrades();                     // file handling, load data from files into arrays and variables before running program
            load_admin_16GoldenLines();                      // file handling, load data from files into arrays and variables before running program
            load_admin_17LifelongEvents();                   // file handling, load data from files into arrays and variables before running program
            load_admin_18Notes();                            // file handling, load data from files into arrays and variables before running program

            char opMain = ' '; // Main menu options, store user input
            while (true)
            {
                header_Welcome(); // welcome header function  is called
                Console.Write("Main Menu > Home ");
                Console.Write("\n");
                Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
                Console.Write("\n");
                opMain = admin_HomeMenu(); // admin home menu is called
                if (opMain == '1')
                {
                    char opLogin; // login option, store user input
                    opLogin = ' ';
                    while (true)
                    {
                        header(); // header function is called
                        Console.Write("Main Menu > Login ");
                        Console.Write("\n");
                        Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
                        Console.Write("\n");
                        Console.Write("Login As");
                        Console.Write("\n");
                        Console.Write("   1. Admin ");
                        Console.Write("\n");
                        Console.Write("   2. Agent ");
                        Console.Write("\n");
                        Console.Write("Press 0 to Go Back...");
                        opLogin = char.Parse( Console.ReadLine());
                        if (opLogin == '0')
                        {
                            break;
                        }
                        else if (opLogin == '1')
                        {
                            string adminUsername = ""; // admin sig-in variable to store username and password
                            string adminPassword = "";
                            header(); // header function is called
                            Console.Write("Main Menu > Login > Admin ");
                            Console.Write("\n");
                            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
                            Console.Write("\n");
                            Console.Write("Sign-In");
                            Console.Write("\n");
                            Console.Write("Username : ");
                            adminUsername = Console.ReadLine();
                            Console.Write("Password : ");
                            adminPassword = Console.ReadLine();
                            int index = checkuser(adminUsername, adminPassword); // check the username and password in the array and make descion upon it
                            if (username[index] == adminUsername && password[index] == adminPassword)
                            {
                                string opAdmin = " "; // admin option, store return value of function admin menu
                                while (true)
                                {
                                    header(); // header function is called
                                    Console.Write("Main Menu > Admin > Menu ");
                                    Console.Write("\n");
                                    Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
                                    Console.Write("\n");
                                    opAdmin = admin_Menu(); // admin menu function is called
                                    if (opAdmin == "0")
                                    {
                                        char opProfile = ' ';
                                        while (opProfile != '1')
                                        {
                                            admin_0Profile(index); // function called
                                            Console.Write("Press 0 to go back...");
                                            opProfile = char.Parse(Console.ReadLine());
                                            if (opProfile == '0')
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.Write("Incorrect option");
                                                Console.Write("\n");
                                                hold_Option();
                                            }
                                        }
                                    }
                                    else if (opAdmin == "1")
                                    {
                                        char opWalletStatus = ' '; //// wallet status option, store user input
                                        while (opWalletStatus != '1')
                                        {
                                            load_agentWalletMoney();
                                            admin_1WalletStatus(); // function called
                                            Console.Write("Press 0 to go back...");
                                            opWalletStatus = char.Parse(Console.ReadLine());
                                            if (opWalletStatus == '0')
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.Write("Incorrect option");
                                                Console.Write("\n");
                                                hold_Option();
                                            }
                                        } // end of opWalletStatus option

                                    } // end of wallet status option of admin menu option

                                    else if (opAdmin == "2")
                                    {
                                        char opExpensesReport = ' '; // expenses report option , store return value of function admin expenses report
                                        while (opExpensesReport != '4')
                                        {
                                            admin_2ExpensesReport(); // function called
                                            opExpensesReport = admin_ExpensesReportMenu(); // admin expenses report function is called
                                            if (opExpensesReport == '0')
                                            {
                                                break;
                                            }
                                            else if (opExpensesReport == '1')
                                            {
                                                char opTodayExpenses = ' '; // today expenses option , store user input
                                                while (opTodayExpenses != '1')
                                                {
                                                    admin_2ExpensesReportToday();
                                                    Console.Write("Press 0 to Go Back...");
                                                    opTodayExpenses = char.Parse(Console.ReadLine());
                                                    if (opTodayExpenses == '0')
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                }
                                            } // end of today expenses report of admin menu option
                                            else if (opExpensesReport == '2')
                                            {
                                                char opExpensesReport1 = ' '; // monthly expenses option , store user input
                                                while (opExpensesReport != '1')
                                                {
                                                    admin_2ExpensesReportMonthly();
                                                    Console.Write("Press 0 to go back...");
                                                    opExpensesReport1 = char.Parse(Console.ReadLine());
                                                    if (opExpensesReport1 == '0')
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop of opExpenses Report

                                            } // end of monthly expense report
                                            else if (opExpensesReport == '3')
                                            {
                                                char opYearExpenses = ' '; // yearly expenses option , store user input
                                                while (opYearExpenses != '1')
                                                {
                                                    admin_2ExpensesReportYearly();
                                                    Console.Write("Press 0 to Go Back...");
                                                    opYearExpenses = char.Parse(Console.ReadLine());
                                                    if (opYearExpenses == '0')
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of yealy expense report

                                            } // end of while loop of opYearExpenses

                                        } // end of while loop of opExpensesReport

                                    } // end of expenses report option of admin menu option
                                    else if (opAdmin == "3")
                                    {
                                        char opAcademicFee = ' '; // academic fee option , store user input
                                        while (opAcademicFee != '1')
                                        {
                                            admin_3AcademicFee(); // fimction called
                                            Console.Write("Press 0 to Go Back...");
                                            opAcademicFee = char.Parse(Console.ReadLine());
                                            if (opAcademicFee == '0')
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.Write("Incorrect option");
                                                Console.Write("\n");
                                                hold_Option();
                                            }
                                        } // end of while loop of opAcademicFee

                                    } // end of academic fee option of admin menu option

                                    else if (opAdmin == "4")
                                    {
                                        char opHostel = ' '; // Hostel option, store return value of hostel menu function
                                        while (opHostel != '8')
                                        {
                                            admin_4Hostel();
                                            opHostel = admin_HostelMenu(); // hostel menu function is called
                                            if (opHostel == '0')
                                            {
                                                break;
                                            }
                                            else if (opHostel == '1')
                                            {
                                                char opMeal = ' '; // meal option, store return value of admin, hostel option of meal menu function
                                                while (true)
                                                {
                                                    admin_4Hostel_1Meal(); // function called
                                                    opMeal = admin_Hostel_MealMenu(); // admin, hostel option of meal menu function is called
                                                    if (opMeal == '0')
                                                    {
                                                        break;
                                                    }
                                                    else if (opMeal == '1')
                                                    {
                                                        char opMealBreakfast = ' '; // meal breakfast option under meal option, store user input
                                                        while (opMealBreakfast != '1')
                                                        {
                                                            admin_4Hostel_1Meal_1Breakfast();
                                                            Console.Write("Press 0 to Go Back...");
                                                            opMealBreakfast = char.Parse(Console.ReadLine());
                                                            if (opMealBreakfast == '0')
                                                            {
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                Console.Write("Incorrect option");
                                                                Console.Write("\n");
                                                                hold_Option();
                                                            }
                                                        } // end of while loop opMealBreakfast

                                                    } // end of breakfast option of meal option of hostel option in admin menu option
                                                    else if (opMeal == '2')
                                                    {
                                                        char opMealLunch = ' '; // meal lunch option under meal option, store user input
                                                        while (opMealLunch != '1')
                                                        {
                                                            admin_4Hostel_1Meal_2Lunch();
                                                            Console.Write("Press 0 to Go Back...");
                                                            opMealLunch = char.Parse(Console.ReadLine());
                                                            if (opMealLunch == '0')
                                                            {
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                Console.Write("Incorrect option");
                                                                Console.Write("\n");
                                                                hold_Option();
                                                            }
                                                        } // end of while loop of opMealLunch

                                                    } // end of lunch option of meal option of hostel option in admin menu option
                                                    else if (opMeal == '3')
                                                    {
                                                        char opMealDinner = ' '; // meal dinner option under meal option, store user input
                                                        while (opMealDinner != '1')
                                                        {
                                                            admin_4Hostel_1Meal_3Dinner();
                                                            Console.Write("Press 0 to Go Back...");
                                                            opMealDinner = char.Parse(Console.ReadLine());
                                                            if (opMealDinner == '0')
                                                            {
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                Console.Write("Incorrect option");
                                                                Console.Write("\n");
                                                                hold_Option();
                                                            }
                                                        } // end of while loop of opMealDinner

                                                    } // end of dinner option of meal option of hostel option in admin menu option

                                                } // end of while loop of opMeal

                                            } // end of meal option of hostel option in admin menu option
                                            else if (opHostel == '2')
                                            {
                                                admin_4Hostel_2MealChargesMonthly();
                                                char opMealCharges = ' '; // monthly meal fee charges  option, store user input
                                                while (opMealCharges != '1')
                                                {

                                                    Console.Write("Press 0 to Go Back...");
                                                    opMealCharges = char.Parse(Console.ReadLine());
                                                    if (opMealCharges == '0')
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {

                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop of opMealCharges

                                            } // end of monthly meal option
                                            else if (opHostel == '3')
                                            {
                                                admin_4Hostel_3LivingChargesMonthly();
                                                char opLivingCharges = ' '; // monthly living fee charges  option, store user input
                                                while (opLivingCharges != '1')
                                                {

                                                    Console.Write("Press 0 to Go Back...");
                                                    opLivingCharges = char.Parse(Console.ReadLine());
                                                    if (opLivingCharges == '0')
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop of opLivingCharges

                                            } // end of living charges
                                            else if (opHostel == '4')
                                            {
                                                admin_4Hostel_4ServiceChargesMonthly();
                                                char opServiceCharges = ' '; // monthly service charges option, store user
                                                while (opServiceCharges != '1')
                                                {

                                                    Console.Write("Press 0 to Go Back...");
                                                    opServiceCharges = char.Parse(Console.ReadLine());
                                                    if (opServiceCharges == '0')
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop of opServiceCharges

                                            } // end of service charges of hostel option
                                            else if (opHostel == '5')
                                            {
                                                admin_4Hostel_5RenovationChargesMonthly();
                                                char opRenovationCharges = ' '; /// monthly renovation charges option, store user input
                                                while (opRenovationCharges != '1')
                                                {

                                                    Console.Write("Press 0 to Go Back...");
                                                    opRenovationCharges = char.Parse(Console.ReadLine());
                                                    if (opRenovationCharges == '0')
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop of opRenovationCharges

                                            } // end of renovation charges of hostel option
                                            else if (opHostel == '6')
                                            {
                                                admin_4Hostel_6LaundryChargesMonthly();
                                                char opLaundryCharges = ' '; // monthly laundry charges option, store user input
                                                while (opLaundryCharges != '1')
                                                {
                                                    opLaundryCharges = char.Parse(Console.ReadLine());
                                                    if (opLaundryCharges == '0')
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop opLaundryCharges

                                            } // end of lundry charges of hostel option
                                            else if (opHostel == '7')
                                            {
                                                admin_4Hostel_7BarberChargesMonthly();
                                                char opBarberCharges = ' '; // barber charges, store user input
                                                while (opBarberCharges != '1')
                                                {

                                                    Console.Write("Press 0 to Go Back...");
                                                    opBarberCharges = char.Parse(Console.ReadLine());
                                                    if (opBarberCharges == '0')

                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of barber charges

                                            } // end of while loop of opBarberCharges

                                        } // end of while loop of opHostel

                                    } // end of hostel option of admin menu option
                                    else if (opAdmin == "5")
                                    {
                                        char opHelpingMaterial = '1'; // helping material, store return value of admin,helping material menu
                                        while (opHelpingMaterial != '4')
                                        {
                                            admin_5HelpingMaterial();
                                            opHelpingMaterial = admin_HelpingMaterialMenu(); // admin,helping material menu is called
                                            if (opHelpingMaterial == '0')
                                            {
                                                break;
                                            }
                                            else if (opHelpingMaterial == '1')
                                            {
                                                char opNotesHelpingMaterial = ' '; // notes option  of helping material option, store user input
                                                while (opNotesHelpingMaterial != '1')
                                                {
                                                    admin_5HelpingMaterial_1Notes();

                                                    Console.Write("Press 0 to Go Back...");
                                                    opNotesHelpingMaterial = char.Parse(Console.ReadLine());
                                                    if (opNotesHelpingMaterial == '0')
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop opNotesHelpingMaterial

                                            } // end of notes option
                                            else if (opHelpingMaterial == '2')
                                            {
                                                char opRegisterHelpingMaterial = ' '; // register option  of helping material option, store user input
                                                while (opRegisterHelpingMaterial != '1')
                                                {
                                                    admin_5HelpingMaterial_2Register();
                                                    Console.Write("Press 0 to Go Back...");
                                                    opRegisterHelpingMaterial = char.Parse(Console.ReadLine());
                                                    if (opRegisterHelpingMaterial == '0')
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop opRegisterHelpingMaterial

                                            } // end of register option
                                            else if (opHelpingMaterial == '3')
                                            {
                                                char opStationaryHelpingMaterial = ' '; // stationary option  of helping material option, store user input
                                                while (opStationaryHelpingMaterial != '1')
                                                {
                                                    admin_5HelpingMaterial_3Stationary();
                                                    Console.Write("Press 0 to Go Back...");
                                                    opStationaryHelpingMaterial = char.Parse(Console.ReadLine());
                                                    if (opStationaryHelpingMaterial == '0')
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop opStationaryHelpingMaterial

                                            } // end of stationary option

                                        } // end of while loop of opHelpingMaterial

                                    } // end of helping material

                                    else if (opAdmin == "6")
                                    {
                                        char opRecreationalExpenses = ' '; // recreational expenses option, store return value of admin,recreational expenses menu
                                        while (opRecreationalExpenses != '3')
                                        {
                                            admin_6RecreationalExpenses();
                                            opRecreationalExpenses = admin_RecreationalExpesesMenu(); // admin,recreational expenses menu is called
                                            if (opRecreationalExpenses == '0')
                                            {
                                                break;
                                            }
                                            else if (opRecreationalExpenses == '1')
                                            {
                                                char opFriendsRecreationalExpenses = ' '; //  friends recreational expenses option,store user input
                                                while (opFriendsRecreationalExpenses != '1')
                                                {
                                                    admin_6RecreationalExpenses_1Friends();
                                                    Console.Write("Press 0 to Go Back...");
                                                    opFriendsRecreationalExpenses = char.Parse(Console.ReadLine());
                                                    if (opFriendsRecreationalExpenses == '0')
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop opFriendsRecreationalExpenses

                                            } // end of  friends recreational expenses option
                                            else if (opRecreationalExpenses == '2')
                                            {
                                                char opFamilyRecreationalExpenses = ' '; //  family recreational expenses option,store user input
                                                while (opFamilyRecreationalExpenses != '1')
                                                {
                                                    admin_6RecreationalExpenses_2Family();
                                                    Console.Write("Press 0 to Go Back...");
                                                    opFamilyRecreationalExpenses = char.Parse(Console.ReadLine());
                                                    if (opFamilyRecreationalExpenses == '0')
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop opFamilyRecreationalExpenses

                                            } // end of family recreational expenses option

                                        } // end of while loop opRecreationalExpenses

                                    } // end of recreatiobnal expenses
                                    else if (opAdmin == "7")
                                    {
                                        char opCommunityFund = ' '; // community fund option, store return value of admin,community fund function
                                        while (opCommunityFund != '3')
                                        {
                                            admin_7CommunityFund();
                                            opCommunityFund = admin_CommunityFundMenu(); // admin,community fund function is called
                                            if (opCommunityFund == '0')
                                            {
                                                break;
                                            }
                                            else if (opCommunityFund == '1')
                                            {
                                                char opClassCommunityFund = ' '; // class community fund option, store user input
                                                while (opClassCommunityFund != '1')
                                                {
                                                    admin_7CommunityFund_1Class();
                                                    Console.Write("Press 0 to Go Back...");
                                                    opClassCommunityFund = char.Parse(Console.ReadLine());
                                                    if (opClassCommunityFund == '0')
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop opClassCommunityFund

                                            } // end of class option of community fund
                                            else if (opCommunityFund == '2')
                                            {
                                                char opSocietiesCommunityFund = ' '; // Socirties fund option, store user input
                                                while (opSocietiesCommunityFund != '1')
                                                {
                                                    admin_7CommunityFund_2Societies();
                                                    Console.Write("Press 0 to Go Back...");
                                                    opSocietiesCommunityFund = char.Parse(Console.ReadLine());
                                                    if (opSocietiesCommunityFund == '0')
                                                    {
                                                        break;
                                                    }

                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop opSocietiesCommunityFund

                                            } // end of societies of

                                        } // end of while loop opCommunityFund

                                    } // end of community fund
                                    else if (opAdmin == "8")
                                    {
                                        char opGoals = ' '; // goals option,store return value of admin, goals menu function
                                        while (opGoals != '5')
                                        {
                                            admin_8Goals();
                                            opGoals = admin_GoalsMenu(); // admin, goals menu function is called
                                            if (opGoals == '0')
                                            {
                                                break;
                                            }
                                            else if (opGoals == '1')
                                            {
                                                char opDailyGoals = ' '; // daiy option of goals option, store user input
                                                while (opDailyGoals != '1')
                                                {
                                                    admin_8Goals_1Daily();
                                                    Console.Write("Press 0 to Go Back...");
                                                    opDailyGoals = char.Parse(Console.ReadLine());
                                                    if (opDailyGoals == '0')
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop opDailyGoals

                                            } // end of daily option of goals option of admin login
                                            else if (opGoals == '2')
                                            {
                                                char opWeeklyGoals; // weekly option of goals option, store user input
                                                while (true)
                                                {
                                                    admin_8Goals_2Weekly();
                                                    Console.Write("Press 0 to Go Back...");
                                                    opWeeklyGoals = char.Parse(Console.ReadLine());
                                                    if (opWeeklyGoals == '0')
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop opWeeklyGoals

                                            } // end of weekly option of goals option of admin login
                                            else if (opGoals == '3')
                                            {
                                                char opMonthlyGoals = ' '; // monthly option of goals option, store user input
                                                while (opMonthlyGoals != '1')
                                                {
                                                    admin_8Goals_3Monthly();
                                                    Console.Write("Press 0 to Go Back...");
                                                    opMonthlyGoals = char.Parse(Console.ReadLine());
                                                    if (opMonthlyGoals == '0')
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop opMonthlyGoals

                                            } // end of monthly option of goals option of admin login
                                            else if (opGoals == '4')
                                            {
                                                char opYearlyGoals = ' '; // yearly option of goals option, store user input
                                                while (opYearlyGoals != '1')
                                                {
                                                    admin_8Goals_4Yearly();
                                                    Console.Write("Press 0 to Go Back...");
                                                    opYearlyGoals = char.Parse(Console.ReadLine());
                                                    if (opYearlyGoals == '0')

                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop opYearlyGoals

                                            } // end of yearly  option of goals option of admin login

                                        } // end of while loop opGoals

                                    } // end of goals option
                                    else if (opAdmin == "9")
                                    {
                                        char opCellPhone = ' '; // cell phone option,store return value admin,cell phone menu function
                                        while (opCellPhone != '4')
                                        {
                                            admin_9CellPhone();
                                            opCellPhone = admin_CellPhoneMenu(); // admin,cell phone menu function  called
                                            if (opCellPhone == '0')
                                            {
                                                break;
                                            }
                                            else if (opCellPhone == '1')
                                            {
                                                char opCall_CellPhone = ' '; // call pakage option of cell option, store user input
                                                while (opCall_CellPhone != '1')
                                                {
                                                    admin_9CellPhone_1Call();
                                                    Console.Write("Press 0 to Go Back...");
                                                    opCall_CellPhone = char.Parse(Console.ReadLine());
                                                    if (opCall_CellPhone == '0')
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop opCall_CellPhone

                                            } // end of call pakage option of cell phone option
                                            else if (opCellPhone == '2')
                                            {
                                                char opInternet_CellPhone = ' '; // internet option of cell phone, store user input
                                                while (opInternet_CellPhone != '1')
                                                {
                                                    admin_9CellPhone_2Internet();
                                                    Console.Write("Press 0 to Go Back...");
                                                    opInternet_CellPhone = char.Parse(Console.ReadLine());
                                                    if (opInternet_CellPhone == '0')
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop opInternet_CellPhone

                                            } // end of  internet option of cell phone
                                            else if (opCellPhone == '3')
                                            {
                                                char opMessage_CellPhone = ' '; // message option of cell phone, store user input
                                                while (opMessage_CellPhone != '1')
                                                {
                                                    admin_9CellPhone_3Message();
                                                    Console.Write("Press 0 to Go Back...");
                                                    opMessage_CellPhone = char.Parse(Console.ReadLine());
                                                    if (opMessage_CellPhone == '0')
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop opMessage_CellPhone

                                            } // end of message option of cell phone

                                        } // end of while loop opCellPhone

                                    } // end of cell phone option of admin option

                                    else if (opAdmin == "10")
                                    {
                                        char opBook = ' '; // book option,store return vale of admin, book menu function
                                        while (opBook != '3')
                                        {
                                            admin_10Book();
                                            opBook = admin_BookMenu(); // admin, book menu function called
                                            if (opBook == '0')
                                            {
                                                break;
                                            }
                                            else if (opBook == '1')
                                            {
                                                char opBookBorrow = ' '; // book borrow option of book option,store user input
                                                while (opBookBorrow != '1')
                                                {
                                                    admin_10Book_1Borrow();
                                                    Console.Write("Press 0 to Go Back...");
                                                    opBookBorrow = char.Parse(Console.ReadLine());
                                                    if (opBookBorrow == '0')
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop opBookBorrow

                                            } // book borrow option of book option,store user input
                                            else if (opBook == '2')
                                            {
                                                char opBookPurchase = ' '; //  book purchase option of book option,store user input
                                                while (opBookPurchase != '1')
                                                {
                                                    admin_10Book_2Purchase();
                                                    Console.Write("Press 0 to Go Back...");
                                                    opBookPurchase = char.Parse(Console.ReadLine());
                                                    if (opBookPurchase == '0')
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop opBookPurchase

                                            } // book purchase option of book option,store user input

                                        } // end of while loop opBook

                                    } // end of book option of admin menu option
                                    else if (opAdmin == "11")
                                    {
                                        char opSelfMotivational = ' '; // self motivational option, store return value of admin,self motivational menu function
                                        while (opSelfMotivational != '4')
                                        {
                                            admin_11SelfMotivational();
                                            opSelfMotivational = admin_SelfMotivationalMenu(); // admin,self motivational menu function called
                                            if (opSelfMotivational == '0')
                                            {
                                                break;
                                            }
                                            else if (opSelfMotivational == '1')
                                            {
                                                char opFiveTimePrayer = ' '; // five time prayer option of self motivstional ,store user input
                                                while (opFiveTimePrayer != '3')
                                                {
                                                    admin_11SelfMotivational_1FiveTimePrayer();
                                                    Console.Write("Press 0 to Go Back...");
                                                    opFiveTimePrayer = char.Parse(Console.ReadLine());
                                                    if (opFiveTimePrayer == '0')
                                                    {
                                                        break;
                                                    }
                                                    else if (opFiveTimePrayer == '1')
                                                    {

                                                        five_time_Prayer[inc_opFiveTimePrayer] = "Yes I Prayer five times! Alhamdulillah.";
                                                        // File Handling
                                                        StreamWriter file = new StreamWriter
                                                         ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_11SelfMotivational_1FiveTimePrayer.txt", true);
                                                        file.WriteLine(five_time_Prayer[inc_opFiveTimePrayer]);
                                                        file.Flush();
                                                        file.Close();
                                                        Console.WriteLine("Data sucessfully saved");
                                                        inc_opFiveTimePrayer += 1;
                                                        hold_Option();
                                                        break;
                                                    }

                                                    else if (opFiveTimePrayer == '2')
                                                    {
                                                        five_time_Prayer[inc_opFiveTimePrayer] = "No I Prayer five times! InshaAllah.";
                                                        // File Handling
                                                        StreamWriter file = new StreamWriter
                                                         ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_11SelfMotivational_1FiveTimePrayer.txt", true);
                                                        file.WriteLine(five_time_Prayer[inc_opFiveTimePrayer]);
                                                        file.Flush();
                                                        file.Close();
                                                        Console.WriteLine("Data sucessfully saved");
                                                        inc_opFiveTimePrayer += 1;
                                                        hold_Option();
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop opFiveTimePrayer

                                            } // five time prayer option of self motivstional option
                                            else if (opSelfMotivational == '2')
                                            {
                                                char opQuran_e_Pak = ' '; // Quran-e-ePak option of self motivational option , store user input
                                                while (opQuran_e_Pak != '3')
                                                {
                                                    admin_11SelfMotivational_2Quran_e_Pak();
                                                    Console.Write("Press 0 to Go Back...");
                                                    opQuran_e_Pak = char.Parse(Console.ReadLine());
                                                    if (opQuran_e_Pak == '0')
                                                    {
                                                        break;
                                                    }
                                                    else if (opQuran_e_Pak == '1')
                                                    {
                                                        Quran_e_Pak[inc_opQuran_e_Pak] = "Yes I recite Quran-e-Pak! Alhamdulillah. ";
                                                        // File Handling
                                                        StreamWriter file = new StreamWriter
                                                         ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_11SelfMotivational_2Quran_e_Pak.txt", true);
                                                        file.WriteLine(Quran_e_Pak[inc_opQuran_e_Pak]);
                                                        file.Flush();
                                                        file.Close();
                                                        Console.WriteLine("Data sucessfully saved");
                                                        inc_opQuran_e_Pak += 1;
                                                        hold_Option();
                                                        break;
                                                    }
                                                    else if (opQuran_e_Pak == '2')
                                                    {
                                                        Quran_e_Pak[inc_opQuran_e_Pak] = "No I will recite Quran-e-Pak! InshaAllah. ";
                                                        // File Handling
                                                        StreamWriter file = new StreamWriter
                                                         ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_11SelfMotivational_2Quran_e_Pak.txt", true);
                                                        file.WriteLine(Quran_e_Pak[inc_opQuran_e_Pak]);
                                                        file.Flush();
                                                        file.Close();
                                                        Console.WriteLine("Data sucessfully saved");
                                                        inc_opQuran_e_Pak += 1;
                                                        hold_Option();
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop opQuran_e_Pak

                                            } // end of Quran-e-ePak option of self motivational option
                                            else if (opSelfMotivational == '3')
                                            {
                                                char opDurood_e_Pak = ' '; // Durood e Pak option of self motivational option,store user input
                                                while (opDurood_e_Pak != '3')
                                                {
                                                    admin_11SelfMotivational_3Durood_e_Pak();
                                                    Console.Write("Press 0 to Go Back...");
                                                    opDurood_e_Pak = char.Parse(Console.ReadLine());
                                                    if (opDurood_e_Pak == '0')
                                                    {
                                                        break;
                                                    }
                                                    else if (opDurood_e_Pak == '1')
                                                    {
                                                        Durood_e_Pak[inc_opDurood_e_Pak] = "Yes I sent Durood-e-Pak to Beloved Prophet peace be upon him! Alhamdulillah.";
                                                        // File Handling
                                                        StreamWriter file = new StreamWriter
                                                         ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_11SelfMotivational_3Durood_e_Pak.txt", true);
                                                        file.WriteLine(Durood_e_Pak[inc_opDurood_e_Pak]);
                                                        file.Flush();
                                                        file.Close();
                                                        Console.WriteLine("Data sucessfully saved");
                                                        inc_opDurood_e_Pak += 1;
                                                        hold_Option();
                                                        break;
                                                    }

                                                    else if (opDurood_e_Pak == '2')
                                                    {
                                                        Durood_e_Pak[inc_opDurood_e_Pak] = "No I will send Durood-e-Pak to Beloved Prophet peace be upon him! InshaAllah.";
                                                        // File Handling
                                                        StreamWriter file = new StreamWriter
                                                         ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_11SelfMotivational_3Durood_e_Pak.txt", true);
                                                        file.WriteLine(Durood_e_Pak[inc_opDurood_e_Pak]);
                                                        file.Flush();
                                                        file.Close();
                                                        Console.WriteLine("Data sucessfully saved");
                                                        inc_opDurood_e_Pak += 1;
                                                        hold_Option();
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop opDurood_e_Pak

                                            } // end of Durood e Pak option of self motivational option

                                        } // end of while loop opSelfMotivational

                                    } // end of  self motivational option of admin menu option
                                    else if (opAdmin == "12")
                                    {
                                        char opTransport = ' '; // transport option, store return value of admin, transport menu funtion
                                        while (opTransport != '3')
                                        {
                                            admin_12Transport();
                                            opTransport = admin_TransportMenu(); // admin, transport menu funtion called
                                            if (opTransport == '0')
                                            {
                                                break;
                                            }
                                            else if (opTransport == '1')
                                            {
                                                char opUberTransport1; // Uber/Cream/Bykea option of tansport option,store user input
                                                while (opTransport != '1')
                                                {
                                                    admin_12Transport_1Uber();
                                                    Console.Write("Press 0 to Go Back...");
                                                    opUberTransport1 = char.Parse(Console.ReadLine());
                                                    if (opUberTransport1 == '0')
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop opUberTransport

                                            } // end of Uber/Cream/Bykea option of tansport option
                                            else if (opTransport == '2')
                                            {
                                                char opBusTransport = ' '; //  bus option of of transport option,store user input
                                                while (opBusTransport != '1')
                                                {
                                                    admin_12Transport_2Bus();
                                                    Console.Write("Press 0 to Go Back...");
                                                    opBusTransport = char.Parse(Console.ReadLine());
                                                    if (opBusTransport == '0')
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop opBusTransport

                                            } // end of bus option of of transport option

                                        } // end of while loop opTransport

                                    } // end of transport option of admin menu option
                                    else if (opAdmin == "13")
                                    {
                                        char opRecreationalActivities = ' '; // recreational activities option , store return value of admin, recreational activities menu function
                                        while (opRecreationalActivities != '3')
                                        {
                                            admin_13RecreationalActivities();
                                            opRecreationalActivities = admin_RecerationActivitiesMenu(); // admin, recreational activities menu function called
                                            if (opRecreationalActivities == '0')
                                            {
                                                break;
                                            }
                                            else if (opRecreationalActivities == '1')
                                            {
                                                char opSportiesActivities = ' '; // sporties activities option of recreational activities option,store user input
                                                while (opSportiesActivities != '1')
                                                {
                                                    admin_13RecreationalActivities_1Sporties();
                                                    Console.Write("Press 0 to Go Back...");
                                                    opSportiesActivities = char.Parse(Console.ReadLine()); 

                                                    if (opSportiesActivities == '0')
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop opSportiesActivities

                                            } // end of Sporties activities option of recreational activities option
                                            else if (opRecreationalActivities == '2')
                                            {
                                                char opSocietiesActivities = ' '; // societies activities option of recreational activities option,store user input
                                                while (opSocietiesActivities != '1')
                                                {
                                                    admin_13RecreationalActivities_2Socities();
                                                    Console.Write("Press 0 to Go Back...");
                                                    opSocietiesActivities = char.Parse(Console.ReadLine());
                                                    if (opSocietiesActivities == '0')
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop opSocietiesActivities

                                            } // end of societies activities option of recreational activities option

                                        } // end of while loop opRecreationalActivities

                                    } // end of recreational activities option of admin menu option
                                    else if (opAdmin == "14")
                                    {
                                        char opAchievements = ' '; // achievments option , store return value of admin,achievments menu function
                                        while (opAchievements != '2')
                                        {
                                            admin_14Achievments();
                                            opAchievements = admin_Achievemnets(); // admin,achievments menu function called
                                            if (opAchievements == '0')
                                            {
                                                break;
                                            }
                                            else if (opAchievements == '1')
                                            {
                                                char opCoCurricular1; // co-curricular option of achievments option, store user input
                                                while (true)
                                                {
                                                    admin_14Achievments_1CoCurricular();
                                                    Console.Write("Press 0 to Go Back...");
                                                    opCoCurricular1 = char.Parse(Console.ReadLine());
                                                    if (opCoCurricular1 == '0')
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop opCoCurricular

                                            } // end of co-curricular option of achievments option
                                            else if (opAchievements == '2')
                                            {
                                                char opExtraCurricular = ' '; // extra-curricular option of achievments option, store user input
                                                while (opExtraCurricular != '1')
                                                {
                                                    admin_14Achievments_2ExtraCurricular();
                                                    Console.Write("Press 0 to Go Back...");
                                                    opExtraCurricular = char.Parse(Console.ReadLine());
                                                    if (opExtraCurricular == '0')
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.Write("Incorrect option");
                                                        Console.Write("\n");
                                                        hold_Option();
                                                    }
                                                } // end of while loop of opExtraCurricular

                                            } // end of extra-curricular option of achievments option

                                        } // end of while loop opAchievements

                                    } // end of achievments option of admin menu option
                                    else if (opAdmin == "15")
                                    {
                                        char opResultGrades = ' '; // result grades option of admin menu option, store user input
                                        while (opResultGrades != '1')
                                        {
                                            admin_15ResultGrades();
                                            Console.Write("Press 0 to Go Back...");
                                            opResultGrades = char.Parse(Console.ReadLine());

                                            if (opResultGrades == '0')
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.Write("Incorrect option");
                                                Console.Write("\n");
                                                hold_Option();
                                            }
                                        } // end of while loop opResultGrades

                                    } // end of result grades option of admin menu option
                                    else if (opAdmin == "16")
                                    {
                                        char opGoldenLines = ' '; // golden lines option of admin menu option, store user input
                                        while (opGoldenLines != '1')
                                        {
                                            admin_16GoldenLines();
                                            Console.Write("Press 0 to Go Back...");
                                            opGoldenLines = char.Parse(Console.ReadLine());
                                            if (opGoldenLines == '0')
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.Write("Incorrect option");
                                                Console.Write("\n");
                                                hold_Option();
                                            }
                                        } // end of while loop opGoldenLines

                                    } // end of golden lines option of admin menu option
                                    else if (opAdmin == "17")
                                    {
                                        char opLifelongEvents = ' '; // lifelong events  option of admin menu option, store user input
                                        while (opLifelongEvents != '1')
                                        {
                                            admin_17LifelongEvents();
                                            Console.Write("Press 0 to Go Back...");
                                            opLifelongEvents = char.Parse(Console.ReadLine());
                                            if (opLifelongEvents == '0')
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.Write("Incorrect option");
                                                Console.Write("\n");
                                                hold_Option();
                                            }
                                        } // end of while loop opLifelongEvents

                                    } // end of lifelong events  option of admin menu option
                                    else if (opAdmin == "18")
                                    {

                                        char opNotes = ' '; // notes option of admin menu option, store user input
                                        while (opNotes != '1')
                                        {
                                            admin_18Notes();
                                            Console.Write("Press 0 to Go Back...");
                                            opNotes = char.Parse(Console.ReadLine());
                                            if (opNotes == '0')
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.Write("Incorrect option");
                                                Console.Write("\n");
                                                hold_Option();
                                            }
                                        } // end of while loop opNotes

                                    } // end of notes option of admin menu option
                                    else if (opAdmin == "19")
                                    {
                                        char opAgentAddUser = ' '; // notes option of admin menu option, store user input
                                        while (opAgentAddUser != '1')
                                        {
                                            admin_19CreateAgentAccount();
                                            Console.Write("Press 0 to Go Back...");
                                            opAgentAddUser = char.Parse(Console.ReadLine());
                                            if (opAgentAddUser == '0')
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.Write("Incorrect option");
                                                Console.Write("\n");
                                                hold_Option();
                                            }
                                        } // end of while loop opNotes

                                    } // end of notes option of admin menu option
                                    else if (opAdmin == "20")
                                    {

                                        break;

                                    } // end of logout option

                                    else
                                    {
                                        Console.Write("Incorrect option");
                                        Console.Write("\n");
                                        hold_Option();
                                    }
                                } // end of While loop of opAdmin menu

                            } //  end of option admin login true securty code
                            else
                            {
                                Console.Write("Incorrect Username and Password");
                                Console.Write("\n");
                                hold_Option();

                            } // end of option admin login false security code

                        } // end of admin login option
                          //******************************* END OF ADMIN MENU OPTION *******************************************
                        else if (opLogin == '2')
                        {
                            string agentUsername = ""; // Agent sig-in variable
                            string agentPassword = "";
                            agentUsername = agentPassword = ""; // variable initiation
                            header(); // header function is called
                            Console.Write("Main Menu > Login > Agent");
                            Console.Write("\n");
                            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
                            Console.Write("\n");
                            Console.Write("Sign-In");
                            Console.Write("\n");
                            Console.Write("Username : ");
                            agentUsername = Console.ReadLine();
                            Console.Write("Password : ");
                            agentPassword = Console.ReadLine();
                            int agentindex = checkuser_agent(agentUsername, agentPassword); // check the username and password in the array and make descion upon it
                            if (username_Agent[agentindex] == agentUsername && password_Agent[agentindex] == agentPassword)
                            {
                                string opAgent = " "; // Agent option , store return value of agent menu function
                                while (true)
                                {
                                    header(); // header function is called
                                    Console.Write("Main Menu > Menu ");
                                    Console.Write("\n");
                                    Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
                                    Console.Write("\n");
                                    opAgent = agent_Menu(); // agent menu function called
                                    if (opAgent == "0")
                                    {
                                        char opProfile = ' ';
                                        while (opProfile != '1')
                                        {
                                            agent_0Profile(agentindex);
                                            Console.Write("Press 0 to go back...");
                                            opProfile = char.Parse(Console.ReadLine());
                                            if (opProfile == '0')
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.Write("Incorrect option");
                                                Console.Write("\n");
                                                hold_Option();
                                            }
                                        }
                                    }
                                    else if (opAgent == "1")
                                    {
                                        char opWallet = ' '; // wallet option, store user input
                                        while (opWallet != '1')
                                        {
                                            agent_1Wallet();
                                            Console.Write("Press 0 to go back...");
                                            opWallet = char.Parse(Console.ReadLine());
                                            if (opWallet == '0')
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.Write("Incorrect option");
                                                Console.Write("\n");
                                                hold_Option();
                                            }
                                        } // end of while loop opWallet

                                    } // enf of wallet option of agent option
                                    else if (opAgent == "2")
                                    {
                                        char opAcademicReport = ' '; // acsdemic report, store user input
                                        while (opAcademicReport != '1')
                                        {
                                            agent_2AcademicReport();
                                            Console.Write("Press 0 to go back...");
                                            opAcademicReport = char.Parse(Console.ReadLine());
                                            if (opAcademicReport == '0')
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.Write("Incorrect option");
                                                Console.Write("\n");
                                                hold_Option();
                                            }
                                        } // end of while loop opAcademicReport

                                    } // end of academic report option of agent option

                                    else if (opAgent == "3")
                                    {
                                        char opExpensesReport; // monthly expenses option , store user input
                                        while (true)
                                        {
                                            agent_3ExpensesReport();
                                            Console.Write("Press 0 to go back...");
                                            opExpensesReport = char.Parse(Console.ReadLine());
                                            if (opExpensesReport == '0')
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.Write("Incorrect option");
                                                Console.Write("\n");
                                                hold_Option();
                                            }
                                        } // end of while loop opExpensesReport

                                    } // end of expenses report of agent option
                                    else if (opAgent == "4")
                                    {
                                        char opMealReport; // meal option ,store user input
                                        while (true)
                                        {
                                            agent_4MealReport();
                                            Console.Write("Press 0 to go back...");
                                            opMealReport = char.Parse(Console.ReadLine());
                                            if (opMealReport == '0')
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.Write("Incorrect option");
                                                Console.Write("\n");
                                                hold_Option();
                                            }
                                        } // end of while loop opMealReport

                                    } // end of meal option of agent option
                                    else if (opAgent == "5")
                                    {
                                        char opTracker; // salah tracker ,store user input
                                        while (true)
                                        {
                                            agent_5SpiritualTracker();
                                            Console.Write("Press 0 to go back...");
                                            opTracker = char.Parse(Console.ReadLine());
                                            if (opTracker == '0')
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.Write("Incorrect option");
                                                Console.Write("\n");
                                                hold_Option();
                                            }
                                        } // end of while loop opTracker

                                    } // salah tracker option of agent option
                                    else if (opAgent == "6")
                                    {
                                        char opAachievmentsReport = ' '; // achivements report,store user input
                                        while (opAachievmentsReport != '1')
                                        {
                                            agent_6AachieventsReport();
                                            Console.Write("Press 0 to go back...");
                                            opAachievmentsReport = char.Parse(Console.ReadLine());
                                            if (opAachievmentsReport == '0')
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.Write("Incorrect option");
                                                Console.Write("\n");
                                                hold_Option();
                                            }
                                        } // end of while loop opAachievmentsReport

                                    } // end of achivements report option of agent option
                                    else if (opAgent == "7")
                                    {
                                        break;
                                    } // end of agent function
                                    else
                                    {
                                        Console.Write("Incorrect option");
                                        Console.Write("\n");
                                        hold_Option();
                                    }
                                } // end of while loop opAgent

                            } // end of agent login true securty code

                            else
                            {
                                Console.Write("Incorrect Username and Password");
                                Console.Write("\n");
                                hold_Option();

                            } // end of agent login False security code

                        } // end of agent login option

                        else
                        {
                            Console.Write("Incorrect option");
                            Console.Write("\n");
                            hold_Option();
                        }

                        //******************************* END OF AGENT OPTION *******************************************c

                    } // end of login option of main menu

                } // end of While loop of opLogin
                else if (opMain == '2')
                {
                    char opAbout = ' '; // about options, store user input
                    while (opAbout != '3')
                    {
                        header(); // header function is called
                        Console.Write("Main Menu > About ");
                        Console.Write("\n");
                        Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
                        Console.Write("\n");
                        Console.Write("1. Version ");
                        Console.Write("\n");
                        Console.Write("2. Developer ");
                        Console.Write("\n");
                        Console.Write("Press 0 to Go Back...");
                        opAbout = char.Parse(Console.ReadLine());

                        if (opAbout == '0')
                        {
                            break;

                        } // end of Go Back of about option
                        else if (opAbout == '1')
                        {
                            char opVersion = ' '; // option version, store user input
                            while (opVersion != '1')
                            {
                                header(); // header function is called
                                Console.Write("Main Menu > About > Version");
                                Console.Write("\n");
                                Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
                                Console.Write("\n");
                                Console.Write("Version : 4.0");
                                Console.Write("\n");
                                Console.Write("Version 04 is developed with the concept of Conditional statments,");
                                Console.Write("\n");
                                Console.Write("Functions, loops, Arrays and File Handling...");
                                Console.Write("\n");
                                Console.Write("Press 0 to Go Back...");
                                opVersion = char.Parse(Console.ReadLine());
                                if (opVersion == '0')
                                {
                                    break;
                                }
                                else
                                {
                                    Console.Write("Incorrect option");
                                    Console.Write("\n");
                                    hold_Option();
                                }
                            } // end of while loop opVersion

                        } // end of version of about option
                        else if (opAbout == '2')
                        {
                            char opDeveloper; // option developer, store user input
                            while (true)
                            {
                                header(); // header function is called
                                Console.Write("Main Menu > About > Developer");
                                Console.Write("\n");
                                Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
                                Console.Write("\n");
                                Console.Write("Instructor     : Dr Awais Hassan");
                                Console.Write("\n");
                                Console.Write("Special thanks : Laeeq Khan Niazi ");
                                Console.Write("\n");
                                Console.Write("Developer      : Muhammad Hammad Hassan");
                                Console.Write("\n");
                                Console.Write("Contact        : +923030299365 ");
                                Console.Write("\n");
                                Console.Write("Press 0 to Go Back...");
                                opDeveloper = char.Parse(Console.ReadLine());
                                if (opDeveloper == '0')
                                {
                                    break;
                                }
                                else
                                {
                                    Console.Write("Incorrect option");
                                    Console.Write("\n");
                                    hold_Option();
                                }
                            } // end of while loop opDeveloper

                        } // end of developer of about option

                    } // end of while loop opAbout

                } // end of about option of menu menu
                else if (opMain == '3')
                {
                    char opAccount = ' '; // create new account  option, store user input
                    while (opAccount != '1')
                    {
                        header(); // header function is called
                        Console.Write("Main Menu > Create an acount ");
                        Console.Write("\n");
                        Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
                        Console.Write("\n");
                        Console.Write("Enter first name : ");
                        firstname[inc_opAddUser] = Console.ReadLine();
                        Console.Write("Enter last name : ");
                        lastname[inc_opAddUser] = Console.ReadLine();
                        Console.Write("Enter username : ");
                        username[inc_opAddUser] = Console.ReadLine();
                        bool check = check_Existing(username[inc_opAddUser]);
                        while (check_Existing(username[inc_opAddUser]) == true)
                        {
                            Console.Write("Username is already exist try another once");
                            Console.Write("\n");
                            Console.Write("Enter username : ");
                            username[inc_opAddUser] = Console.ReadLine();
                        }
                        Console.Write("Enter password :");
                        password[inc_opAddUser] = Console.ReadLine();
                        // File Handling
                        StreamWriter file = new StreamWriter
                         ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\adminSecurityFile.txt", true);
                        file.WriteLine(firstname[inc_opAddUser] + "," + lastname[inc_opAddUser] + "," + username[inc_opAddUser] + "," + password[inc_opAddUser]);
                        file.Flush();
                        file.Close();
                        Console.WriteLine("Data sucessfully saved");
                        inc_opAddUser += 1;
                        Console.Write("Press 0 to Go Back...");
                        opAccount = char.Parse(Console.ReadLine());
                        if (opAccount == '0')
                        {
                            break;
                        }
                        else
                        {
                            Console.Write("Incorrect option");
                            Console.Write("\n");
                            hold_Option();
                            break;
                        }
                    }
                } // end of create new account option
                else if (opMain == '4')
                {
                    char opExit = ' '; // Exit options, store user input
                    header(); // header function is called
                    Console.Write("Main Menu > Exit ");
                    Console.Write("\n");
                    Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
                    Console.Write("\n");
                    Console.Write("Are you sure to want to Exit?");
                    Console.Write("\n");
                    Console.Write("1. Yes ");
                    Console.Write("\n");
                    Console.Write("2. No ");
                    Console.Write("\n");
                    Console.Write("Press 0 to Go Back...");
                    opExit = char.Parse(Console.ReadLine());
                    if (opExit == '0')
                    {
                        continue;
                    }
                    else if (opExit == '1')
                    {
                        header(); // header is called
                        Console.Write("Thanks for using University Student Diary Managment System");
                        Console.Write("\n");
                        Console.Write("Take Care...Allah Hafiz");
                        Console.ReadLine();
                        break;
                    } // end of exit Yes, Program will terminate
                    else if (opExit == '2')
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write("Incorrect option");
                        Console.Write("\n");
                        hold_Option();
                    }

                } // exit option of admin home menu
                else
                {
                    Console.Write("Invalid option...");
                    Console.Write("\n");
                    hold_Option();

                } // message show  invalid option of option main screen

            } // end while loop main menu
            Console.ReadLine();
        }//end of main functio 
         //********************* Functions Definition ************************
        static void header()
        {
            Console.Clear();
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("*************                                                           *************");
            Console.WriteLine("********                                                                     ********");
            Console.WriteLine("***                  University Student Diary Management System                   ***");
            Console.WriteLine("********                                                                     ********");
            Console.WriteLine("*************                                                           *************");
            Console.WriteLine("*************************************************************************************");

        } // header funtion end
        static void header_Welcome()
        {
            Console.Clear();
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("*************                                                           *************");
            Console.WriteLine("********                                                                     ********");
            Console.WriteLine("***             Welcome to University Student Diary Management System             ***");
            Console.WriteLine("********                                                                     ********");
            Console.WriteLine("*************                                                           *************");
            Console.WriteLine("*************************************************************************************");
        } // end of header welcome funtion
        static char admin_HomeMenu()
        {
            char opMain;
            Console.WriteLine("1. Login");
            Console.WriteLine("2. About");
            Console.WriteLine("3. Create an acount");
            Console.WriteLine("4. Exit");
            Console.Write("Press the number... ");
            opMain =char.Parse( Console.ReadLine());
            return opMain;
        } // end of admin home menu
        static void hold_Option()
        {
            Console.WriteLine("Press anykey to continue...");
            Console.ReadLine();
        } // end of hold option function
          //********************* SECURITY ************************
        static int checkuser(string user_name, string pass_word)
        {
            int index = -1;
            for (int i = 0; i < 20; i++)
            {
                if (user_name == username[i] && pass_word == password[i])
                {
                    index = i;
                }
            }
            return index;
        } // end of check username
        static bool check_Existing(string username_check)
        {
            for (int i = 0; i < inc_opAddUser; i++)
            {
                if (username_check == username[i])
                {
                    return true;
                }
            }
            return false;

        } // end of check exiting username
        static int checkuser_agent(string agent_user_name, string agent_pass_word)
        {
            int index_agent = -1;
            for (int i = 0; i < length; i++)
            {
                if (agent_user_name == username_Agent[i] && agent_pass_word == password_Agent[i])
                {
                    index_agent = i;
                }
            }

            return index_agent;
        }
        static bool check_Existing_agent(string agent_username_check)
        {
            for (int i = 0; i < inc_opAgentAddUser; i++)
            {
                if (agent_username_check == username_Agent[i])
                {
                    return true;
                }
            }
            return false;
        }
        //****************** ADMIN ******************
        static void admin_0Profile(int indexValue)
        {

            header(); // header function is called
            Console.WriteLine("Main Menu > Admin > Menu > Profile");
            Console.WriteLine("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.WriteLine("                                   __WELCOME ON BOARD__                             ");
            Console.WriteLine("First name : ");
            Console.Write(firstname[indexValue]);
            Console.Write("\t");
            Console.Write("Last name : ");
            Console.WriteLine(lastname[indexValue]);
            Console.WriteLine("_____________________________________________________________________________________");
            Console.WriteLine("Recommendations:-");
            admin_Recommendation();
            Console.WriteLine("_____________________________________________________________________________________");
            display_profile_admin();
        } // end of option 0 profle of admin
        static void admin_1WalletStatus()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Wallet Status ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Current Blance:");
            Console.Write(addWalletMoney - total_Expenses());
            Console.Write("\n");
            Console.Write("Remarks from Agent:");
            Console.Write(walletRemarks);
            Console.Write("\n");
        } // end of admin option 1
        static void admin_2ExpensesReport()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Expenses Report ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
        } // end of admin option 1
        static void admin_2ExpensesReportToday()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Expenses Report > Today  ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            display_breakfast();
            Console.Write("_____________________________________________________________________________________");
            Console.Write("\n");
            display_lunch();
            Console.Write("_____________________________________________________________________________________");
            Console.Write("\n");
            display_dinner();
        } // end of admin option 2 of today report
        static void admin_2ExpensesReportMonthly()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > ExpensesReport > Monthly");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Monthly Report :- ");
            Console.Write("\n");
            Console.Write("Personal................: ");
            Console.Write(personal_Expenses());
            Console.Write("\n");
            Console.Write("Hostel..................: ");
            Console.Write(hostel_Expenses());
            Console.Write("\n");
            Console.Write("Helping Material........: ");
            Console.Write(helpingmaterial_Expenses());
            Console.Write("\n");
            Console.Write("Recreational Expenses...: ");
            Console.Write(recreational_Expenses());
            Console.Write("\n");
            Console.Write("Fund....................: ");
            Console.Write(communityfund_Expenses());
            Console.Write("\n");
            Console.Write("Cell Phone..............: ");
            Console.Write(cellphone_Expenses());
            Console.Write("\n");
            Console.Write("Transport...............: ");
            Console.Write(transport_Expenses());
            Console.Write("\n");
            Console.Write("                   Total: ");
            Console.Write(total_Expenses());
            Console.Write("\n");
        } // end of admin option 2 of monthly option
        static void admin_2ExpensesReportYearly()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > ExpensesReport > Year  ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            display_academicFee(); // sorted academic fee function called
        } // end of admin option 2 of yearly
        static void admin_3AcademicFee()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Academic Fee ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Semester type : ");
            semesterType[increment_opAcademicFee] =Console.ReadLine();
            Console.Write("Challan no : ");
            challanNo[increment_opAcademicFee] = Console.ReadLine();
            Console.Write("Amount : ");
            amountacademic[increment_opAcademicFee] = float_Validaion("Amount : ",Console.ReadLine());
            Console.Write("Date : ");
            date[increment_opAcademicFee] = Console.ReadLine();
            Console.Write("Remarks  : ");
            remarks[increment_opAcademicFee] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin3AcadmicFee.txt", true);
            file.WriteLine(semesterType[increment_opAcademicFee] + "," + amountacademic[increment_opAcademicFee]+","+ date[increment_opAcademicFee]+""+ remarks[increment_opAcademicFee]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            increment_opAcademicFee += 1; // after storing data successfully,increase the index by 1
        } // end of admin option 3
        static void admin_4Hostel()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Hostel");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
        } // end of admin 4 option
        static void admin_4Hostel_1Meal()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Hostel > Meal  ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
        } // end of admin 4 option of sub option 1 meal
        static void admin_4Hostel_1Meal_1Breakfast()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Hostel > Meal > Breakfast Charges ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Note: If you Hostilities, add 000 in charges.");
            Console.Write("\n");
            Console.Write("Menu : ");
            menuBreakfast[increment_opMealBreakfast] = Console.ReadLine();
            Console.Write("Charges : ");
            chargesBreakfast[increment_opMealBreakfast] = float_Validaion("Charges : ", Console.ReadLine());
            Console.Write("Remarks : ");
            remarksBreakfast[increment_opMealBreakfast] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_4Hostel_1Meal_1Breakfast.txt", true);
            file.WriteLine(menuBreakfast[increment_opMealBreakfast] + "," + chargesBreakfast[increment_opMealBreakfast] + "," + remarksBreakfast[increment_opMealBreakfast]);
            file.Flush();
            file.Close();
            increment_opMealBreakfast += 1;
        } // end of function
        static void admin_4Hostel_1Meal_2Lunch()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Hostel > Meal > Lunch Charges ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Note: If you Hostilities, add 000 in charges.");
            Console.Write("\n");
            Console.Write("Menu : ");
            menuLunch[increment_opMealLunch] = Console.ReadLine();
            Console.Write("Charges : ");
            chargesLunch[increment_opMealLunch] = float_Validaion("Charges : ", Console.ReadLine());
            Console.Write("Remarks : ");
            remarksLunch[increment_opMealLunch] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_4Hostel_1Meal_2Lunch.txt", true);
            file.WriteLine(menuLunch[increment_opMealLunch] + "," + chargesLunch[increment_opMealLunch] + "," + remarksLunch[increment_opMealLunch]);
            file.Flush();
            file.Close();
            increment_opMealLunch += 1;
        } // end of function
        static void admin_4Hostel_1Meal_3Dinner()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Hostel > Meal > Dinner Charges ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Note: If you Hostilities, add 000 in charges.");
            Console.Write("\n");
            Console.Write("Menu : ");
            menuDinner[increment_opMealDinner] = Console.ReadLine();
            Console.Write("Charges : ");
            chargesDinner[increment_opMealDinner] = float_Validaion("Charges : ", Console.ReadLine());
            Console.Write("Remarks : ");
            remarksDinner[increment_opMealDinner] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
           ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_4Hostel_1Meal_3Dinner.txt", true);
            file.WriteLine(menuDinner[increment_opMealDinner] + "," + chargesDinner[increment_opMealDinner] + "," + remarksDinner[increment_opMealDinner]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            increment_opMealDinner += 1;
        } // end of function
        static void admin_4Hostel_2MealChargesMonthly()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Hostel > Monthly fee Charges  ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Month : ");
            monthlyMealExpenses[increment_opMealCharges] = Console.ReadLine();
            Console.Write("Charges : ");
            chargesMealMonthly[increment_opMealCharges] = float_Validaion("Charges : ", Console.ReadLine());
            Console.Write("Remarks : ");
            remarksMealExpenses[increment_opMealCharges] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
           ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_4Hostel_2MealChargesMonthly.txt", true);
            file.WriteLine(monthlyMealExpenses[increment_opMealCharges] + "," + chargesMealMonthly[increment_opMealCharges] + "," + remarksMealExpenses[increment_opMealCharges]);
            file.Flush();
            file.Close();
            increment_opMealCharges += 1;
        } // end of function
        static void admin_4Hostel_3LivingChargesMonthly()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Hostel > Living Charges  ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Month : ");
            monthLivingExpenses[inc_opLivingCharges] = Console.ReadLine();
            Console.Write("Charges : ");
            chargesLivingExpenses[inc_opLivingCharges] = float_Validaion("Charges : ", Console.ReadLine());
            Console.Write("Remarks : ");
            remarksLivingExpenses[inc_opLivingCharges] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
          ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_4Hostel_3LivingChargesMonthly.txt", true);
            file.WriteLine(monthLivingExpenses[inc_opLivingCharges] + "," + chargesLivingExpenses[inc_opLivingCharges] + "," + remarksLivingExpenses[inc_opLivingCharges]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opLivingCharges += 1;
        } // end of function
        static void admin_4Hostel_4ServiceChargesMonthly()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Hostel > Service Charges  ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Month : ");
            monthServiceExpenses[inc_opServiceCharges] = Console.ReadLine();
            Console.Write("Charges : ");
            chargesServiceMonthly[inc_opServiceCharges] = float_Validaion("Charges : ", Console.ReadLine());
            Console.Write("Remarks : ");
            remarksServiceExpenses[inc_opServiceCharges] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
          ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_4Hostel_4ServiceChargesMonthly.txt", true);
            file.WriteLine(monthServiceExpenses[inc_opServiceCharges] + "," + chargesServiceMonthly[inc_opServiceCharges] + "," + remarksServiceExpenses[inc_opServiceCharges]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opServiceCharges += 1;
        } // end of function
        static void admin_4Hostel_5RenovationChargesMonthly()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Hostel > Renovation Charges  ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Charges : ");
            chargesRenovationMonthly[inc_opRenovationCharges] = float_Validaion("Charges : ", Console.ReadLine());
            Console.Write("Remarks : ");
            remarksRenovationExpenses[inc_opRenovationCharges] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
         ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_4Hostel_5RenovationChargesMonthly.txt", true);
            file.WriteLine(chargesRenovationMonthly[inc_opRenovationCharges] + "," + remarksRenovationExpenses[inc_opRenovationCharges]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opRenovationCharges += 1;
        } // end of function
        static void admin_4Hostel_6LaundryChargesMonthly()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Hostel > Laundry Charges  ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Charges : ");
            chargesLaundryMonthly[inc_opLaundryCharges] = float_Validaion("Charges : ", Console.ReadLine());
            remarksLaundryExpenses[inc_opLaundryCharges] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
        ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_4Hostel_6LaundryChargesMonthly.txt", true);
            file.WriteLine(chargesLaundryMonthly[inc_opLaundryCharges] + "," + remarksLaundryExpenses[inc_opLaundryCharges]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opLaundryCharges += 1;
            Console.Write("Press 0 to Go Back...");
        } // end of function
        static void admin_4Hostel_7BarberChargesMonthly()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Hostel > Laundry Charges  ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Charges : ");
            chargesBarberMonthly[inc_opBarberCharges] = float_Validaion("Charges : ", Console.ReadLine());
            Console.Write("Remarks : ");
            remarksBarberExpenses[inc_opBarberCharges] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
       ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_4Hostel_7BarberChargesMonthly.txt", true);
            file.WriteLine(chargesBarberMonthly[inc_opBarberCharges] + "," + remarksBarberExpenses[inc_opBarberCharges]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opBarberCharges += 1;
        } // end of function
        static void admin_5HelpingMaterial()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Helping Material  ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
        } // end of function
        static void admin_5HelpingMaterial_1Notes()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Helping Material > Notes ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Charges : ");
            chargesNotesMonthly[inc_opNotesHelpingMaterial] = float_Validaion("Charges : ", Console.ReadLine());
            Console.Write("Remarks : ");
            remarksNotesExpenses[inc_opNotesHelpingMaterial] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
      ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_5HelpingMaterial_1Notes.txt", true);
            file.WriteLine(chargesNotesMonthly[inc_opNotesHelpingMaterial] + "," + remarksNotesExpenses[inc_opNotesHelpingMaterial]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opNotesHelpingMaterial += 1;
        } // end of function
        static void admin_5HelpingMaterial_2Register()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Helping Material > Register ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Charges : ");
            chargesRegisterMonthly[inc_opRegisterHelpingMaterial] = float_Validaion("Charges : ", Console.ReadLine());
            Console.Write("Remarks : ");
            remarksRegisterExpenses[inc_opRegisterHelpingMaterial] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
     ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_5HelpingMaterial_2Register.txt", true);
            file.WriteLine(chargesRegisterMonthly[inc_opRegisterHelpingMaterial] + "," + remarksRegisterExpenses[inc_opRegisterHelpingMaterial]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opRegisterHelpingMaterial += 1;
        } // end of function
        static void admin_5HelpingMaterial_3Stationary()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Helping Material > Stationary ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Charges : ");
            chargesStationaryMonthly[inc_opStationaryHelpingMaterial] = float_Validaion("Charges : ", Console.ReadLine());
            Console.Write("Remarks : ");
            remarksStationaryExpenses[inc_opStationaryHelpingMaterial] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
    ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_5HelpingMaterial_3Stationary.txt", true);
            file.WriteLine(chargesStationaryMonthly[inc_opStationaryHelpingMaterial] + "," + remarksStationaryExpenses[inc_opStationaryHelpingMaterial]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opStationaryHelpingMaterial += 1;
        } // end of function
        static void admin_6RecreationalExpenses()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Recreational Expenses  ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
        } // end of function
        static void admin_6RecreationalExpenses_1Friends()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Recreational Expenses > Friends  ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Charges : ");
            chargesFriendsRecreationalExpenses[inc_opFriendsRecreationalExpenses] = float_Validaion("Charges : ", Console.ReadLine());
            Console.Write("Remarks : ");
            remarksFriendsRecreationalExpenses[inc_opFriendsRecreationalExpenses] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
   ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_6RecreationalExpenses_1Friends.txt", true);
            file.WriteLine(chargesFriendsRecreationalExpenses[inc_opFriendsRecreationalExpenses] + "," + remarksFriendsRecreationalExpenses[inc_opFriendsRecreationalExpenses]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opFriendsRecreationalExpenses += 1;
        } // end of function
        static void admin_6RecreationalExpenses_2Family()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Recreational Expenses > Family  ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Charges : ");
            chargesFamilyRecreationalExpenses[inc_opFamilyRecreationalExpenses] = float_Validaion("Charges : ", Console.ReadLine());
            Console.Write("Remarks : ");
            remarksFamilyRecreationalExpenses[inc_opFamilyRecreationalExpenses] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
   ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_6RecreationalExpenses_2Family.txt", true);
            file.WriteLine(chargesFamilyRecreationalExpenses[inc_opFamilyRecreationalExpenses] + "," + remarksFamilyRecreationalExpenses[inc_opFamilyRecreationalExpenses]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opFamilyRecreationalExpenses += 1;
        } // end of function
        static void admin_7CommunityFund()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Community Fund  ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
        } // end of function
        static void admin_7CommunityFund_1Class()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Community Fund ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Objective : ");
            remarksClassCommunityFund[inc_opClassCommunityFund] = Console.ReadLine();
            Console.Write("Charges : ");
            chargesClassCommunityFund[inc_opClassCommunityFund] = float_Validaion("Charges : ", Console.ReadLine());
            // File Handling
            StreamWriter file = new StreamWriter
("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_7CommunityFund_1Class.txt", true);
            file.WriteLine(remarksClassCommunityFund[inc_opClassCommunityFund] + "," + chargesClassCommunityFund[inc_opClassCommunityFund]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opClassCommunityFund += 1;
        } // end of function
        static void admin_7CommunityFund_2Societies()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Community Fund ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Objective : ");
            remarksSocietiesCommunityFund[inc_opSocietiesCommunityFund] = Console.ReadLine();
            Console.Write("Charges : ");
            chargesSocietiesCommunityFund[inc_opSocietiesCommunityFund] = float_Validaion("Charges : ", Console.ReadLine());
            // File Handling
            StreamWriter file = new StreamWriter
("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_7CommunityFund_2Societies.txt", true);
            file.WriteLine(remarksSocietiesCommunityFund[inc_opSocietiesCommunityFund] + "," + chargesSocietiesCommunityFund[inc_opSocietiesCommunityFund]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opSocietiesCommunityFund += 1;
        } // end of function
        static void admin_8Goals()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Goals ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
        } // end of function
        static void admin_8Goals_1Daily()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Goals > Daily ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Title : ");
            titleDailyGoals[inc_opDailyGoals] = Console.ReadLine();
            Console.Write("Description : ");
            descriptionDailyGoals[inc_opDailyGoals] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_8Goals_1Daily.txt", true);
            file.WriteLine(titleDailyGoals[inc_opDailyGoals] + "," + descriptionDailyGoals[inc_opDailyGoals]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opDailyGoals += 1;
        } // end of function
        static void admin_8Goals_2Weekly()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Goals > Weekly ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Title : ");
            titleWeeklyGoals[inc_opWeeklyGoals] = Console.ReadLine();
            Console.Write("Description : ");
            descriptionWeeklyGoals[inc_opWeeklyGoals] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_8Goals_2Weekly.txt", true);
            file.WriteLine (titleWeeklyGoals[inc_opWeeklyGoals] + "," + descriptionWeeklyGoals[inc_opWeeklyGoals]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opWeeklyGoals += 1;
        } // end of function
        static void admin_8Goals_3Monthly()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Goals > Monthly ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Title : ");
            titleMonthlyGoals[inc_opMonthlyGoals] = Console.ReadLine();
            Console.Write("Description : ");
            descriptionMonthlyGoals[inc_opMonthlyGoals] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_8Goals_3Monthly.txt", true);
            file.WriteLine(titleMonthlyGoals[inc_opMonthlyGoals] + "," + descriptionMonthlyGoals[inc_opMonthlyGoals]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opMonthlyGoals += 1;
        } // end of function
        static void admin_8Goals_4Yearly()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Goals > Monthly ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Title : ");
            titleYearlyGoals[inc_opYearlyGoals] = Console.ReadLine();
            Console.Write("Description : ");
            descriptionYearlyGoals[inc_opYearlyGoals] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_8Goals_4Yearly.txt", true);
            file.WriteLine(titleYearlyGoals[inc_opYearlyGoals] + "," + descriptionYearlyGoals[inc_opYearlyGoals]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opYearlyGoals += 1;
        } // end of function
        static void admin_9CellPhone()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Cell Phone ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
        } // end of function
        static void admin_9CellPhone_1Call()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Cell Phone > Call Pakage ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Name : ");
            nameCallPakage[inc_opCall_CellPhone] = Console.ReadLine();
            Console.Write("Amount : ");
            amountCallPakage[inc_opCall_CellPhone] = float_Validaion("Amount : ", Console.ReadLine());
            Console.Write("Duration : ");
            // File Handling
            StreamWriter file = new StreamWriter
("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_9CellPhone_1Call.txt", true);
            file.WriteLine(nameCallPakage[inc_opCall_CellPhone] + "," + amountCallPakage[inc_opCall_CellPhone]+","+ durationCallPakage[inc_opCall_CellPhone]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opCall_CellPhone += 1;
        } // end of function
        static void admin_9CellPhone_2Internet()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Cell Phone > Internet Pakage ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Name : ");
            nameInternetPakage[inc_opInternet_CellPhone] = Console.ReadLine();
            Console.Write("Amount : ");
            amountInternetPakage[inc_opInternet_CellPhone] = float_Validaion("Amount : ", Console.ReadLine());
            Console.Write("Duration : ");
            durationInternetPakage[inc_opInternet_CellPhone] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_9CellPhone_2Internet.txt", true);
              file.WriteLine(nameInternetPakage[inc_opInternet_CellPhone] + "," + amountInternetPakage[inc_opInternet_CellPhone] + ","+ durationInternetPakage[inc_opInternet_CellPhone]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opInternet_CellPhone += 1;
        } // end of function
        static void admin_9CellPhone_3Message()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Cell Phone > Message Pakage ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Name : ");
            nameMessagePakage[inc_opMessage_CellPhone] = Console.ReadLine();
            Console.Write("Amount : ");
            amountMessagePakage[inc_opMessage_CellPhone] = float_Validaion("Amount : ", Console.ReadLine());
            Console.Write("Duration : ");
            durationMessagePakage[inc_opMessage_CellPhone] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_9CellPhone_3Message.txt", true);
            file.WriteLine(nameMessagePakage[inc_opMessage_CellPhone] + "," + amountMessagePakage[inc_opMessage_CellPhone] + "," + durationMessagePakage[inc_opMessage_CellPhone]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opMessage_CellPhone += 1;
        } // end of function
        static void admin_10Book()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Book ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
        } // end of function
        static void admin_10Book_1Borrow()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Book > Borrow ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Title : ");
            titleBorrowBook[inc_opBookBorrow] = Console.ReadLine();
            Console.Write("Author: : ");
            authorBorrowBook[inc_opBookBorrow] = Console.ReadLine();
            Console.Write("Friend Name : ");
            friendnameBorrowBook[inc_opBookBorrow] = Console.ReadLine();
            Console.Write("Remarks : ");
            remarksBorrowBook[inc_opBookBorrow] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_10Book_1Borrow.txt", true);
            file.WriteLine(titleBorrowBook[inc_opBookBorrow] + "," + authorBorrowBook[inc_opBookBorrow] + "," + friendnameBorrowBook[inc_opBookBorrow]+","+ remarksBorrowBook[inc_opBookBorrow]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opBookBorrow += 1;
        } // end of function
        static void admin_10Book_2Purchase()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Book > Purchase ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Title : ");
            titlePurchaseBook[inc_opBookPurchase] = Console.ReadLine();
            Console.Write("Author: : ");
            authorPurchaseBook[inc_opBookPurchase] = Console.ReadLine();
            Console.Write("Purchase : ");
            amountPurchaseBook[inc_opBookPurchase] = float_Validaion("Purchase : ", Console.ReadLine());
            Console.Write("Remarks : ");
            remarksPurchaseBook[inc_opBookPurchase] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_10Book_2Purchase.txt", true);
            file.WriteLine(titlePurchaseBook[inc_opBookPurchase] + "," + authorPurchaseBook[inc_opBookPurchase] + "," + amountPurchaseBook[inc_opBookPurchase] + "," + remarksPurchaseBook[inc_opBookPurchase]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opBookPurchase = +1;
        } // end of function
        static void admin_11SelfMotivational()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Spiritual Food ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
        } // end of function
        static void admin_11SelfMotivational_1FiveTimePrayer()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Spiritual Food > Five-time Prayer ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Is you prayer five times?");
            Console.Write("\n");
            Console.Write("   1. Yes");
            Console.Write("\n");
            Console.Write("   2. No");
            Console.Write("\n");
        } // end of function
        static void admin_11SelfMotivational_2Quran_e_Pak()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Spiritual Food > Quran-e-Pak ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Is you Recite Quran-e-Pak?");
            Console.Write("\n");
            Console.Write("   1. Yes");
            Console.Write("\n");
            Console.Write("   2. No");
            Console.Write("\n");
        } // header function is called
        static void admin_11SelfMotivational_3Durood_e_Pak()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Spiritual Food > Quran-e-Pak ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Is you send Durood-e-Pak to Beloved Prophet peace be upon him");
            Console.Write("\n");
            Console.Write("   1. Yes");
            Console.Write("\n");
            Console.Write("   2. No");
            Console.Write("\n");
        } // header function is called
        static void admin_12Transport()
        {
            header(); // header function is called;
            Console.Write("Main Menu > Admin > Menu > Transport ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
        } // end of function
        static void admin_12Transport_1Uber()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Transport > Uber/Cream/Bykea ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Location from : ");
            locationFromUber[inc_opUberTransport] = Console.ReadLine();
            Console.Write("Location to: ");
            locationToUber[inc_opUberTransport] = Console.ReadLine();
            Console.Write("Amount : ");
            amountUber[inc_opUberTransport] = float_Validaion("Amount : ", Console.ReadLine());
            Console.Write("Purpose : ");
            purposeUber[inc_opUberTransport] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_12Transport_1Uber.txt", true);
            file.WriteLine(locationFromUber[inc_opUberTransport] + "," + locationToUber[inc_opUberTransport] + "," + amountUber[inc_opUberTransport] + "," + purposeUber[inc_opUberTransport]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opUberTransport += 1;
        } // end of function
        static void admin_12Transport_2Bus()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Transport > Bus ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Location from : ");
            locationFromBus[inc_opBusTransport] = Console.ReadLine();
            Console.Write("Location to: ");
            locationToBus[inc_opBusTransport] = Console.ReadLine();
            Console.Write("Ticket Price : ");
            amountBus[inc_opBusTransport] = float_Validaion("Ticket Price : ", Console.ReadLine());
            Console.Write("Purpose : ");
            purposeBus[inc_opBusTransport] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_12Transport_2Bus.txt", true);
            file.WriteLine(locationFromBus[inc_opBusTransport] + "," + locationToBus[inc_opBusTransport] + "," + amountBus[inc_opBusTransport] + "," + purposeBus[inc_opBusTransport]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opBusTransport += 1;
        } // end of function
        static void admin_13RecreationalActivities()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Recreational Activities ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
        } // end of function
        static void admin_13RecreationalActivities_1Sporties()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Recreational Activities > Sporties ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("How much time you service?");
            Console.Write("\n");
            Console.Write("Minuties: ");
            minutiesSporties[inc_opSportiesActivities] = float_Validaion("Minuties: ", Console.ReadLine());
            // File Handling
            StreamWriter file = new StreamWriter
("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_13RecreationalActivities_1Sporties.txt", true);
            file.WriteLine(minutiesSporties[inc_opSportiesActivities]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opSportiesActivities += 1;
        } // end of function
        static void admin_13RecreationalActivities_2Socities()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Recreational Activities > Societies ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("How much time you service?");
            Console.Write("\n");
            Console.Write("Minuties: ");
            minutiesSocieties[inc_opSocietiesActivities] = float_Validaion("Minuties: ", Console.ReadLine());
            Console.Write("Purpose: ");
            purposeSocieties[inc_opSocietiesActivities] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_13RecreationalActivities_2Socities.txt", true);
            file.WriteLine(minutiesSocieties[inc_opSocietiesActivities] + "," + purposeSocieties[inc_opSocietiesActivities]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opSocietiesActivities += 1;
        } // end of function
        static void admin_14Achievments()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Achievements ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
        } // end of function
        static void admin_14Achievments_1CoCurricular()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Achievements > Co-Curricular ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Award/Certificate: ");
            awardCo_Curricular[inc_opCoCurricular] = Console.ReadLine();
            Console.Write("Presented by: ");
            presentCo_Curricular[inc_opCoCurricular] = Console.ReadLine();
            Console.Write("Remarks: ");
            remarksCo_Curricular[inc_opCoCurricular] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_14Achievments_1CoCurricular.txt", true);
            file.WriteLine(awardCo_Curricular[inc_opCoCurricular] + "," + presentCo_Curricular[inc_opCoCurricular]+","+ remarksCo_Curricular[inc_opCoCurricular]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opCoCurricular += 1;
        } // end of function
        static void admin_14Achievments_2ExtraCurricular()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Achievements > Extra-Curricular ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Award/Certificate: ");
            awardExtra_Curricular[inc_opExtraCurricular] = Console.ReadLine();
            Console.Write("Presented by: ");
            presentExtra_Curricular[inc_opExtraCurricular] = Console.ReadLine();
            Console.Write("Remarks: ");
            remarksExtra_Curricular[inc_opExtraCurricular] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_14Achievments_2ExtraCurricular.txt", true);
            file.WriteLine(awardExtra_Curricular[inc_opExtraCurricular] + "," + presentExtra_Curricular[inc_opExtraCurricular] + "," + remarksExtra_Curricular[inc_opExtraCurricular]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opExtraCurricular += 1;
        } // end of function
        static void admin_15ResultGrades()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Result Grades ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("GPA : ");
            gpa[inc_opResultGrades] = float_Validaion("GPA : ", Console.ReadLine());
            Console.Write("CGPA : ");
            cgpa[inc_opResultGrades] = float_Validaion("CGPA : ", Console.ReadLine());
            Console.Write("Remarks : ");
            remarksResult[inc_opResultGrades] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_15ResultGrades.txt", true);
            file.WriteLine(gpa[inc_opResultGrades] + "," + cgpa[inc_opResultGrades] + "," + remarksResult[inc_opResultGrades]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opResultGrades += 1;
        } // end of function
        static void admin_16GoldenLines()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Golden Lines ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Title : ");
            titleGoldenLines[inc_opGoldenLines] = Console.ReadLine();
            Console.Write("Description:");
            descriptionGoldenLines[inc_opGoldenLines] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_16GoldenLines.txt", true);
            file.WriteLine(titleGoldenLines[inc_opGoldenLines] + "," + descriptionGoldenLines[inc_opGoldenLines]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opGoldenLines += 1;
        } // end of function
        static void admin_17LifelongEvents()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Lifelong Events ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Title : ");
            titleLifelongEvents[inc_opLifelongEvents] = Console.ReadLine();
            Console.Write("Description:");
            descriptionLifelongEvents[inc_opLifelongEvents] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_17LifelongEvents.txt", true);
            file.WriteLine(titleLifelongEvents[inc_opLifelongEvents] + "," + descriptionLifelongEvents[inc_opLifelongEvents]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opLifelongEvents += 1;
        } // end of function
        static void admin_18Notes()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Notes ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Title : ");
            titleNotes[inc_opNotes] = Console.ReadLine();
            Console.Write("Description:");
            descriptionNotes[inc_opNotes] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_18Notes.txt", true);
            file.WriteLine(titleNotes[inc_opNotes] + "," + descriptionNotes[inc_opNotes]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opNotes += 1;
        } // end of function
        static void admin_19CreateAgentAccount()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > Create agent account");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Enter first name : ");
            firstname_Agent[inc_opAgentAddUser] = Console.ReadLine();
            Console.Write("Enter last name : ");
            lastname_Agent[inc_opAgentAddUser] = Console.ReadLine();
            Console.Write("Enter username : ");
            username_Agent[inc_opAgentAddUser] = Console.ReadLine();
            // bool agent_check = check_Existing_agent(username_Agent[inc_opAgentAddUser]); // to make username unique
            while (check_Existing_agent(username_Agent[inc_opAgentAddUser]) == true)
            {
                Console.Write("Username is already exist try another once");
                Console.Write("\n");
                Console.Write("Enter username : ");
                username_Agent[inc_opAgentAddUser] = Console.ReadLine();
            }
            Console.Write("Enter password :");
            password_Agent[inc_opAgentAddUser] = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\agentSecurityFile.txt", true);
            file.WriteLine(firstname_Agent[inc_opAgentAddUser] + "," + lastname_Agent[inc_opAgentAddUser]+"," + username_Agent[inc_opAgentAddUser]+"," + password_Agent[inc_opAgentAddUser]);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
            inc_opAgentAddUser += 1;
        } // end of function
          //****************** ADMIN EXPLANATION ******************
        static string admin_Menu()
        {
            string opAdmin = ""; // admin option, store user input
            Console.Write("Choose Option");
            Console.Write("\n");
            Console.Write("   0. Profile");
            Console.Write("\n");
            Console.Write("   1. Wallet Status ");
            Console.Write("\n");
            Console.Write("   2. Expenses Report ");
            Console.Write("\n");
            Console.Write("   3. Academic Fee ");
            Console.Write("\n");
            Console.Write("   4. Hostel ");
            Console.Write("\n");
            Console.Write("   5. Helping Material");
            Console.Write("\n");
            Console.Write("   6. Recreational Expenses");
            Console.Write("\n");
            Console.Write("   7. Community Fund");
            Console.Write("\n");
            Console.Write("   8. Goals");
            Console.Write("\n");
            Console.Write("   9. Cell Phone");
            Console.Write("\n");
            Console.Write("   10.Books");
            Console.Write("\n");
            Console.Write("   11.Spiritual Food");
            Console.Write("\n");
            Console.Write("   12.Transport");
            Console.Write("\n");
            Console.Write("   13.Recreational Activities");
            Console.Write("\n");
            Console.Write("   14.Achievements");
            Console.Write("\n");
            Console.Write("   15.Result Grades");
            Console.Write("\n");
            Console.Write("   16.Golden Lines");
            Console.Write("\n");
            Console.Write("   17.Lifelong Events");
            Console.Write("\n");
            Console.Write("   18.Notes");
            Console.Write("\n");
            Console.Write("   19.Create agent account");
            Console.Write("\n");
            Console.Write("   20.Logout");
            Console.Write("\n");
            Console.Write("Choose option...");
            opAdmin = Console.ReadLine();
            return opAdmin;
        } // end of admin menu
        static char admin_ExpensesReportMenu()
        {
            char opExpensesReport; // expenses report option , store user input
            Console.Write("Choose Option");
            Console.Write("\n");
            Console.Write("   1. Today");
            Console.Write("\n");
            Console.Write("   2. Month");
            Console.Write("\n");
            Console.Write("   3. Year");
            Console.Write("\n");
            Console.Write("Press 0 to Go Back...");
            opExpensesReport =char.Parse( Console.ReadLine());
            return opExpensesReport;
        } // end of admin expenses report menu function
        static char admin_HostelMenu()
        {
            char opHostel; // Hostel option, store user input
            Console.Write("Choose Option");
            Console.Write("\n");
            Console.Write("   1. Meal");
            Console.Write("\n");
            Console.Write("   2. Monthly Meal Charges");
            Console.Write("\n");
            Console.Write("   3. Living Charges");
            Console.Write("\n");
            Console.Write("   4. Service  Charges");
            Console.Write("\n");
            Console.Write("   5. Renovation Charges");
            Console.Write("\n");
            Console.Write("   6. Laundry Charges");
            Console.Write("\n");
            Console.Write("   7. Barber Charges");
            Console.Write("\n");
            Console.Write("Press 0 to Go Back...");
            opHostel = char.Parse(Console.ReadLine());
                return opHostel;
        } // end of admin hostel menu function
        static char admin_Hostel_MealMenu()
        {
            char opMeal; // meal option, store user input
            Console.Write("Choose Option");
            Console.Write("\n");
            Console.Write("   1. Breakfast Charges");
            Console.Write("\n");
            Console.Write("   2. Lunch Charges");
            Console.Write("\n");
            Console.Write("   3. Dinner Charges");
            Console.Write("\n");
            Console.Write("Press 0 to Go Back...");
            opMeal =char.Parse( Console.ReadLine());
            return opMeal;
        } // end of admin, hostel option of meal menu function
        static char admin_HelpingMaterialMenu()
        {
            char opHelpingMaterial; // helping material, store user input
            Console.Write("Choose Option");
            Console.Write("\n");
            Console.Write("   1. Notes");
            Console.Write("\n");
            Console.Write("   2. Register");
            Console.Write("\n");
            Console.Write("   3. Stationary");
            Console.Write("\n");
            Console.Write("Press 0 to Go Back...");
            opHelpingMaterial =char.Parse( Console.ReadLine());
            return opHelpingMaterial;
        } // end of admin,helping material menu function
        static char admin_RecreationalExpesesMenu()
        {
            char opRecreationalExpenses; // recreational expenses option, store user input
            Console.Write("Choose Option");
            Console.Write("\n");
            Console.Write("   1. Friend");
            Console.Write("\n");
            Console.Write("   2. Family");
            Console.Write("\n");
            Console.Write("Press 0 to Go Back...");
            opRecreationalExpenses = char.Parse(Console.ReadLine());
            return opRecreationalExpenses;
        } // end of admin,recreational expenses menu function
        static char admin_CommunityFundMenu()
        {
            char opCommunityFund; // community fund option, store user input
            Console.Write("Choose Option");
            Console.Write("\n");
            Console.Write("   1. Class");
            Console.Write("\n");
            Console.Write("   2. Societies");
            Console.Write("\n");
            Console.Write("Press 0 to Go Back...");
            opCommunityFund = char.Parse(Console.ReadLine());
            return opCommunityFund;
        } // end of admin,community fund function
        static char admin_GoalsMenu()
        {
            char opGoals; // goals, store user input
            Console.Write("Choose Option");
            Console.Write("\n");
            Console.Write("   1. Daily");
            Console.Write("\n");
            Console.Write("   2. Weekly");
            Console.Write("\n");
            Console.Write("   3. Monthly");
            Console.Write("\n");
            Console.Write("   4. Yearly");
            Console.Write("\n");
            Console.Write("Press 0 to Go Back...");
            opGoals = char.Parse(Console.ReadLine());
            return opGoals;
        } // end of admin, goals menu function
        static char admin_CellPhoneMenu()
        {
            char opCellPhone; // cell phone option,store user input
            Console.Write("Choose Option");
            Console.Write("\n");
            Console.Write("   1. Call Package");
            Console.Write("\n");
            Console.Write("   2. Internet Package");
            Console.Write("\n");
            Console.Write("   3. Message Package");
            Console.Write("\n");
            Console.Write("Press 0 to Go Back...");
            opCellPhone = char.Parse(Console.ReadLine());
            return opCellPhone;
        } // end of admin,cell phone menu function
        static char admin_BookMenu()
        {
            char opBook; // book option of admin option
            Console.Write("Choose Option");
            Console.Write("\n");
            Console.Write("   1. Borrow");
            Console.Write("\n");
            Console.Write("   2. Purchase");
            Console.Write("\n");
            Console.Write("Press 0 to Go Back...");
            opBook = char.Parse(Console.ReadLine());
            return opBook;
        } // end of admin, book menu function
        static char admin_SelfMotivationalMenu()
        {
            char opSelfMotivational; // self motivational option of admin menu option,store user input
            Console.Write("Choose Option");
            Console.Write("\n");
            Console.Write("   1. Five-time Prayer");
            Console.Write("\n");
            Console.Write("   2. Quran-e-Pak Recitation");
            Console.Write("\n");
            Console.Write("   3. Durood-e-Pak");
            Console.Write("\n");
            Console.Write("Press 0 to Go Back...");
            opSelfMotivational = char.Parse(Console.ReadLine());
            return opSelfMotivational;
        } // end of admin,self motivational menu function
        static char admin_TransportMenu()
        {
            char opTransport; // transport option of admin menu option
            Console.Write("Choose Option");
            Console.Write("\n");
            Console.Write("   1. Uber/Cream/Bykea");
            Console.Write("\n");
            Console.Write("   2. Bus");
            Console.Write("\n");
            Console.Write("Press 0 to Go Back...");
            opTransport = char.Parse(Console.ReadLine());
            return opTransport;
        } // end of admin, transport menu funtion
        static char admin_RecerationActivitiesMenu()
        {
            char opRecreationalActivities; // recreational activities option of admin menu option,store user input
            Console.Write("Choose Option");
            Console.Write("\n");
            Console.Write("   1. Sporties");
            Console.Write("\n");
            Console.Write("   2. Societies");
            Console.Write("\n");
            Console.Write("Press 0 to Go Back...");
            opRecreationalActivities = char.Parse(Console.ReadLine());
            return opRecreationalActivities;
        } // end of admin, recreational activities menu function
        static char admin_Achievemnets()
        {
            char opAchievements; // achievments option of admin menu option,store user input
            Console.Write("Choose Option");
            Console.Write("\n");
            Console.Write("   1. Co-Curricular");
            Console.Write("\n");
            Console.Write("   2. Extra- Curricular");
            Console.Write("\n");
            Console.Write("Press 0 to Go Back...");
            opAchievements = char.Parse(Console.ReadLine());
            return opAchievements;
        } // end of admin,achievments menu function
        static void display_profile_admin()
        {
            if (titleDailyGoals == null && descriptionDailyGoals==null)
            { // totday goal
                Console.Write("Today goals data is not avilable");
                Console.Write("\n");
            }
            else
            {
                if (descriptionDailyGoals==null)
                {
                    Console.Write("Today goals data is not avilable");
                    Console.Write("\n");
                }
                else
                {
                    Console.Write("Today Goals...");
                    Console.Write("\n");
                    for (int i = 0; i < inc_opDailyGoals; i++)
                    {
                        Console.Write("        Title:");
                        Console.Write(titleDailyGoals[i]);
                        Console.Write("\n");
                        Console.Write("Discription:");
                        Console.Write(descriptionDailyGoals[i]);
                        Console.Write("\n");
                    }
                }
            }
            Console.Write("_____________________________________________________________________________________");
            Console.Write("\n");
            if (titleWeeklyGoals==null && descriptionWeeklyGoals==null)
            { // weekly goal
                Console.Write("Weekly goals data is not avilable");
                Console.Write("\n");
            }
            else
            {
                if (descriptionWeeklyGoals== null)
                {
                    Console.Write("Weekly goals data is not avilable");
                    Console.Write("\n");
                }
                else
                {
                    Console.Write("Weekly Goals...");
                    Console.Write("\n");
                    for (int i = 0; i < inc_opWeeklyGoals; i++)
                    {
                        Console.Write("        Title:");
                        Console.Write(titleWeeklyGoals[i]);
                        Console.Write("\n");
                        Console.Write("Discription:");
                        Console.Write(descriptionWeeklyGoals[i]);
                        Console.Write("\n");
                    }
                }
            }
            Console.Write("_____________________________________________________________________________________");
            Console.Write("\n");
            if (titleMonthlyGoals == null && descriptionMonthlyGoals == null)
            { // Monthly goal
                Console.Write("Monthly goals data is not avilable");
                Console.Write("\n");
            }
            else
            {
                if (descriptionMonthlyGoals == null)
                {
                    Console.Write("Monthly goals data is not avilable");
                    Console.Write("\n");
                }
                else
                {
                    Console.Write("Monthly Goals...");
                    Console.Write("\n");
                    for (int i = 0; i < inc_opMonthlyGoals; i++)
                    {
                        Console.Write("        Title:");
                        Console.Write(titleMonthlyGoals[i]);
                        Console.Write("\n");
                        Console.Write("Discription:");
                        Console.Write(descriptionMonthlyGoals[i]);
                        Console.Write("\n");
                    }
                }
            }
            Console.Write("_____________________________________________________________________________________");
            Console.Write("\n");
            if (titleYearlyGoals == null && descriptionYearlyGoals == null)
            { // Yearly goal
                Console.Write("Yearly goals data is not avilable");
                Console.Write("\n");
            }
            else
            {
                if (descriptionYearlyGoals == null)
                {
                    Console.Write("Yearly goals data is not avilable");
                    Console.Write("\n");
                }
                else
                {
                    Console.Write("Yearly Goals...");
                    Console.Write("\n");
                    for (int i = 0; i < inc_opYearlyGoals; i++)
                    {
                        Console.Write("        Title:");
                        Console.Write(titleYearlyGoals[i]);
                        Console.Write("\n");
                        Console.Write("Discription:");
                        Console.Write(descriptionYearlyGoals[i]);
                        Console.Write("\n");
                    }
                }
            }
            Console.Write("_____________________________________________________________________________________");
            Console.Write("\n");
        } // end of profile admin option
          //****************** RECOMMENDATIOM ******************
        static void admin_Recommendation()
        {
            if (addWalletMoney >= 0 && addWalletMoney <= 200)
            {
                Console.Write("You have low money...!");
                Console.Write("\n");
            }
            for (int i = 0; i < inc_opResultGrades; i++)
            {
                if (gpa[i] < 2.0 || cgpa[i] < 2.0)
                {
                    Console.Write("Work hard...You can do it!!!");
                    Console.Write("\n");
                }
            }
        }
        //********************* AGENT FUNCTIONS ************************
        static void agent_0Profile(int agentindex)
        {
            header(); // header function is called
            Console.Write("Main Menu > Agent > Menu > Profile");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("                                 __WELCOME ON BOARD__                             ");
            Console.Write("\n");
            Console.Write("First name : ");
            Console.Write(firstname_Agent[agentindex]);
            Console.Write("\t");
            Console.Write("Last name : ");
            Console.Write(lastname_Agent[agentindex]);
            Console.Write("\n");
        } // end of functions
        static void agent_1Wallet()
        {
            header(); // header function is called
            Console.Write("Main Menu > Agent > Menu > Wallet  ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Current Balance:");
            Console.Write("\n");
            Console.Write("Add Balance: ");
            addWalletMoney = float_Validaion("Add Balance: ", Console.ReadLine()); // wallet money will show in admin wallet status
            Console.Write("Remarks: ");
            walletRemarks = Console.ReadLine();
            // File Handling
            StreamWriter file = new StreamWriter
("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\agentWalletMoney.txt");
            file.WriteLine(addWalletMoney+","+ walletRemarks);
            file.Flush();
            file.Close();
            Console.WriteLine("Data sucessfully saved");
        } // end of functions
        static void agent_2AcademicReport()
        {
            header(); // header function is called
            Console.Write("Main Menu > Agent > Menu > Academic Report  ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            if (gpa[0] == 0 && cgpa[0] == 0)
            {
                Console.Write("Data is not avilable");
                Console.Write("\n");
            }
            else
            {
                Console.Write("Sr.No \tGPA \tCGPA \tRemarks");
                Console.Write("\n");
                for (int i = 0; i < inc_opResultGrades; i++)
                {
                    Console.Write(i + 1);
                    Console.Write("\t");
                    Console.Write(gpa[i]);
                    Console.Write("\t");
                    Console.Write(cgpa[i]);
                    Console.Write("\t");
                    Console.Write(remarksResult[i]);
                    Console.Write("\n");
                }
            }
        } // end of functions
        static void agent_3ExpensesReport()
        {
            header(); // header function is called
            Console.Write("Main Menu > Admin > Menu > ExpensesReport > Monthly");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Monthly Report :- ");
            Console.Write("\n");
            Console.Write("Personal................: ");
            Console.Write(personal_Expenses());
            Console.Write("\n");
            Console.Write("Hostel..................: ");
            Console.Write(hostel_Expenses());
            Console.Write("\n");
            Console.Write("Helping Material........: ");
            Console.Write(helpingmaterial_Expenses());
            Console.Write("\n");
            Console.Write("Recreational Expenses...: ");
            Console.Write(recreational_Expenses());
            Console.Write("\n");
            Console.Write("Fund....................: ");
            Console.Write(communityfund_Expenses());
            Console.Write("\n");
            Console.Write("Cell Phone..............: ");
            Console.Write(cellphone_Expenses());
            Console.Write("\n");
            Console.Write("Transport...............: ");
            Console.Write(transport_Expenses());
            Console.Write("\n");
            Console.Write("                   Total: ");
            Console.Write(total_Expenses());
            Console.Write("\n");
        } // end of functions
        static void agent_4MealReport()
        {
            header(); // header function is called
            Console.Write("Main Menu > Agent > Menu >  Meal Report  ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            if (menuBreakfast==null&& menuLunch == null && menuDinner == null)
            {
                Console.Write("Data is not avilable");
                Console.Write("\n");
            }
            else
            {
                if (menuBreakfast== null)
                {
                    Console.Write("Breakfast data is not avilable");
                    Console.Write("\n");
                }
                else
                {
                    Console.Write("Sr.No \tBreakfast Menu \tRemarks \tCharges");
                    Console.Write("\n");
                    for (int i = 0; i < increment_opMealBreakfast; i++)
                    {
                        Console.Write(i + 1);
                        Console.Write("\t");
                        Console.Write(menuBreakfast[i]);
                        Console.Write("\t\t");
                        Console.Write(remarksBreakfast[i]);
                        Console.Write("\t\t");
                        Console.Write(chargesBreakfast[i]);
                        Console.Write("\n");
                    }
                }
                if (menuLunch == null)
                {
                    Console.Write("__________________________");
                    Console.Write("\n");
                    Console.Write("Lunch data is not avilable");
                    Console.Write("\n");
                }
                else
                {
                    Console.Write("________________________________________________");
                    Console.Write("\n");
                    Console.Write("Sr.No \tLunch Menu \tRemarks \tCharges");
                    Console.Write("\n");

                    for (int i = 0; i < increment_opMealLunch; i++)
                    {
                        Console.Write(i + 1);
                        Console.Write("\t");
                        Console.Write(menuLunch[i]);
                        Console.Write("\t\t");
                        Console.Write(remarksLunch[i]);
                        Console.Write("\t\t");
                        Console.Write(chargesLunch[i]);
                        Console.Write("\n");
                    }
                }
                if (menuDinner == null)
                {
                    Console.Write("____________________________");
                    Console.Write("\n");
                    Console.Write("Dinner data is not avilable");
                    Console.Write("\n");
                }
                else
                {
                    Console.Write("________________________________________________");
                    Console.Write("\n");
                    Console.Write("Sr.No \tDinner Menu \tRemarks \tCharges");
                    Console.Write("\n");
                    for (int i = 0; i < increment_opMealDinner; i++)
                    {
                        Console.Write(i + 1);
                        Console.Write("\t");
                        Console.Write(menuDinner[i]);
                        Console.Write("\t\t");
                        Console.Write(remarksDinner[i]);
                        Console.Write("\t\t");
                        Console.Write(chargesDinner[i]);
                        Console.Write("\n");
                    }
                }
            }
            Console.Write("________________________________________________");
            Console.Write("\n");
        } // end of functions
        static void agent_5SpiritualTracker()
        {
            header(); // header function is called
            Console.Write("Main Menu > Agent > Menu > Spiritual Tracker  ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            Console.Write("Summary...");
            Console.Write("\n");
            if (five_time_Prayer==null && Quran_e_Pak == null && Durood_e_Pak == null)
            {
                Console.Write("Data is not avilable");
                Console.Write("\n");
            }
            else
            {
                if (five_time_Prayer == null)
                {
                    Console.Write("Salah tracker data is not avilable");
                    Console.Write("\n");
                }
                else
                {
                    Console.Write("Sr.No \tSalah Tracker...");
                    Console.Write("\n");
                    for (int i = 0; i < inc_opFiveTimePrayer; i++)
                    {
                        Console.Write(i + 1);
                        Console.Write("\t");
                        Console.Write(five_time_Prayer[i]);
                        Console.Write("\n");
                    }
                }
                if (Quran_e_Pak == null)
                {
                    Console.Write("Quran-e-Pak tracker data is not avilable");
                    Console.Write("\n");
                }
                else
                {
                    Console.Write("__________________________________");
                    Console.Write("\n");
                    Console.Write("Sr.No \tQuran-e-Pak Tracker...");
                    Console.Write("\n");
                    for (int i = 0; i < inc_opQuran_e_Pak; i++)
                    {
                        Console.Write(i + 1);
                        Console.Write("\t");
                        Console.Write(Quran_e_Pak[i]);
                        Console.Write("\n");
                    }
                }
                if (Durood_e_Pak == null)
                {
                    Console.Write("Durood-e-Pak tracker data is not avilable");
                    Console.Write("\n");
                }
                else
                {
                    Console.Write("__________________________________");
                    Console.Write("\n");
                    Console.Write("Sr.No \tDurood-e-Pak Tracker...");
                    Console.Write("\n");
                    for (int i = 0; i < inc_opDurood_e_Pak; i++)
                    {
                        Console.Write(i + 1);
                        Console.Write("\t");
                        Console.Write(Durood_e_Pak[i]);
                        Console.Write("\n");
                    }
                }
            }
            Console.Write("__________________________________");
            Console.Write("\n");
        } // end of functions
        static void agent_6AachieventsReport()
        {
            header(); // header function is called
            Console.Write("Main Menu > Agent > Menu > Achievments Report  ");
            Console.Write("\n");
            Console.Write("__________ . __________ . __________ . _________ . __________ . _________ . _________");
            Console.Write("\n");
            if (awardCo_Curricular == null && awardExtra_Curricular == null && remarksCo_Curricular == null && remarksExtra_Curricular == null)
            {
                Console.Write("Data is not avilable");
                Console.Write("\n");
            }
            else
            {
                if (awardCo_Curricular == null)
                {
                    Console.Write("Co-curricular achievements data is not avilable");
                    Console.Write("\n");
                }
                else
                {
                    Console.Write("Co-Curricular Achievements...");
                    Console.Write("\n");
                    Console.Write("Sr.No \tAward/Certificate \tPresented by \tRemarks ");
                    Console.Write("\n");
                    for (int i = 0; i < inc_opCoCurricular; i++)
                    {
                        Console.Write(i + 1);
                        Console.Write("\t");
                        Console.Write(awardCo_Curricular[i]);
                        Console.Write("\t\t\t");
                        Console.Write(presentCo_Curricular[i]);
                        Console.Write("\t\t");
                        Console.Write(remarksCo_Curricular[i]);
                        Console.Write("\n");
                    }
                }
                if (awardExtra_Curricular == null)
                {
                    Console.Write("Extra-curricular achievements data is not avilable");
                    Console.Write("\n");
                }
                else
                {
                    Console.Write("________________________________________________");
                    Console.Write("\n");
                    Console.Write("Sr.No \tAward/Certificate \tPresented by \tRemarks ");
                    Console.Write("\n");
                    for (int i = 0; i < inc_opExtraCurricular; i++)
                    {
                        Console.Write(i + 1);
                        Console.Write("\t");
                        Console.Write(awardExtra_Curricular[i]);
                        Console.Write("\t\t\t");
                        Console.Write(presentExtra_Curricular[i]);
                        Console.Write("\t\t");
                        Console.Write(remarksExtra_Curricular[i]);
                        Console.Write("\n");
                    }
                }
            }
            Console.Write("________________________________________________");
            Console.Write("\n");
        } // end of functions
          //****************** AGENT FUNCTION EXPLANATION ******************
        static string agent_Menu()
        {
            string opAgent = ""; // option Agent
            Console.Write("Choose Option");
            Console.Write("\n");
            Console.Write("   0. Profile");
            Console.Write("\n");
            Console.Write("   1. Wallet");
            Console.Write("\n");
            Console.Write("   2. Academic Report");
            Console.Write("\n");
            Console.Write("   3. Expenese Report");
            Console.Write("\n");
            Console.Write("   4. Meal Report");
            Console.Write("\n");
            Console.Write("   5. Spiritual Tracker");
            Console.Write("\n");
            Console.Write("   6. Aachievments Report");
            Console.Write("\n");
            Console.Write("   7. Logout");
            Console.Write("\n");
            Console.Write("Choose option...");
            opAgent = Console.ReadLine();
            return opAgent;
        } // end of agent menu function
          //********************* ADMIN & AGENT FUNCTION ************************
        static int personal_Expenses()
        {
            float personalExpenses = 0.0F; // sum of purchase book + academic fee
            float purchasebook = 0.0F;
            float academicfee = 0.0F;
            for (int i = 0; i < inc_opBookPurchase; i++)
            {
                purchasebook += amountPurchaseBook[i];
            }
            for (int i = 0; i < increment_opAcademicFee; i++)
            {
                academicfee += amountacademic[i];
            }
            personalExpenses = purchasebook + (academicfee / 6);
            return (int)personalExpenses;
        } // end of personal expenses function
        static int hostel_Expenses()
        {
            float hostelExpenses = 0.0F; // sum of breakfast + lunch + dinner + mealMonthly + livingMonthly + serviceMonthly + renovationMonthly + laundryMonthly + barbermonthly
            float breakfast = 0.0F;
            float lunch = 0.0F;
            float dinner = 0.0F;
            float mealMonthly = 0.0F;
            float livingMonthly = 0.0F;
            float serviceMonthly = 0.0F;
            float renovationMonthly = 0.0F;
            float laundryMonthly = 0.0F;
            float barbermonthly = 0.0F;
            for (int i = 0; i < increment_opMealBreakfast; i++)
            {
                breakfast += chargesBreakfast[i];
            }
            for (int i = 0; i < increment_opMealLunch; i++)
            {
                lunch += chargesLunch[i];
            }
            for (int i = 0; i < increment_opMealDinner; i++)
            {
                dinner += chargesDinner[i];
            }
            for (int i = 0; i < increment_opMealCharges; i++)
            {
                mealMonthly += chargesMealMonthly[i];
            }
            for (int i = 0; i < inc_opLivingCharges; i++)
            {
                livingMonthly += chargesLivingExpenses[i];
            }
            for (int i = 0; i < inc_opServiceCharges; i++)
            {
                serviceMonthly += chargesServiceMonthly[i];
            }
            for (int i = 0; i < inc_opRenovationCharges; i++)
            {
                renovationMonthly += chargesRenovationMonthly[i];
            }
            for (int i = 0; i < inc_opLaundryCharges; i++)
            {
                laundryMonthly += chargesLaundryMonthly[i];
            }
            for (int i = 0; i < inc_opBarberCharges; i++)
            {
                barbermonthly += chargesBarberMonthly[i];
            }
            hostelExpenses = breakfast + lunch + dinner + mealMonthly + livingMonthly + serviceMonthly + renovationMonthly + laundryMonthly + barbermonthly;
            return (int)hostelExpenses;
        } // end of hostel expenses function
        static int helpingmaterial_Expenses()
        {
            float helpingmaterialExpenses = 0.0F; // sum of notes + register_ + stationary
            float notes = 0.0F;
            float register_ = 0.0F;
            float stationary = 0.0F;
            for (int i = 0; i < inc_opNotesHelpingMaterial; i++)
            {
                notes = chargesNotesMonthly[i];
            }
            for (int i = 0; i < inc_opRegisterHelpingMaterial; i++)
            {
                register_ = chargesRegisterMonthly[i];
            }
            for (int i = 0; i < inc_opStationaryHelpingMaterial; i++)
            {
                stationary = chargesStationaryMonthly[i];
            }
            helpingmaterialExpenses = notes + register_ + stationary;
            return (int)helpingmaterialExpenses;
        } // end of helping material function
        static int recreational_Expenses()
        {
            float recreationalExpenses = 0.0F; // sum of friends + family
            float friends = 0.0F;
            float family = 0.0F;
            for (int i = 0; i < inc_opFriendsRecreationalExpenses; i++)
            {
                friends = chargesFriendsRecreationalExpenses[i];
            }
            for (int i = 0; i < inc_opFamilyRecreationalExpenses; i++)
            {
                family = chargesFamilyRecreationalExpenses[i];
            }
            recreationalExpenses = friends + family;
            return (int)recreationalExpenses;
        } // end of recreational expenses function
        static int communityfund_Expenses()
        {
            float communityfundExpenses = 0.0F; // sum of classes + socities
            float classes = 0.0F;
            float socities = 0.0F;
            for (int i = 0; i < inc_opClassCommunityFund; i++)
            {
                classes = chargesClassCommunityFund[i];
            }
            for (int i = 0; i < inc_opSocietiesCommunityFund; i++)
            {
                socities = chargesSocietiesCommunityFund[i];
            }
            communityfundExpenses = classes + socities;
            return (int)communityfundExpenses;
        } // end of community fund expenses function
        static int cellphone_Expenses()
        {
            float cellphoneExpenses = 0.0F; // sum of call + internet + message
            float call = 0.0F;
            float internet = 0.0F;
            float message = 0.0F;
            for (int i = 0; i < inc_opCall_CellPhone; i++)
            {
                call = amountCallPakage[i];
            }
            for (int i = 0; i < inc_opInternet_CellPhone; i++)
            {
                internet = amountInternetPakage[i];
            }
            for (int i = 0; i < inc_opMessage_CellPhone; i++)
            {
                message = amountMessagePakage[i];
            }
            cellphoneExpenses = call + internet + message;
            return (int)cellphoneExpenses;
        } // end of cell phone expenses function
        static int transport_Expenses()
        {
            float transportExpenses = 0.0F; // sum of uber + bus
            float uber = 0.0F;
            float bus = 0.0F;
            for (int i = 0; i < inc_opUberTransport; i++)
            {
                uber = amountUber[i];
            }
            for (int i = 0; i < inc_opBusTransport; i++)
            {
                bus = amountBus[i];
            }
            transportExpenses = uber + bus;
            return (int)transportExpenses;
        } // end of transport expenses function
        static int total_Expenses()

        {
            int totalExpenses = (int)0.0; // sum of  personalExpenses + hostelExpenses + helpingmaterialExpenses + recreationalExpenses + communityfundExpenses + cellphoneExpenses + transportExpenses
            totalExpenses = personal_Expenses() + hostel_Expenses() + helpingmaterial_Expenses() + recreational_Expenses() + communityfund_Expenses() + cellphone_Expenses() + transport_Expenses();
            //totalExpenses = totalExpenses - addWalletMoney;
            return totalExpenses;
        } // end of total expneses function
          //********************* SORTING FUNCTION ************************
        static void sort_academicFee()
        {
            for (int i = 0; i < increment_opAcademicFee; i++)
            {
                for (int j = i + 1; j < increment_opAcademicFee; j++)
                {
                    if (amountacademic[j] > amountacademic[i])
                    {
                        float temp = amountacademic[i];
                        amountacademic[i] = amountacademic[j];
                        amountacademic[j] = temp;
                        // semester type sort
                        string temp_type = semesterType[i];
                        semesterType[i] = semesterType[j];
                        semesterType[j] = temp_type;
                        // challan no sort
                        temp_type = challanNo[i];
                        challanNo[i] = challanNo[j];
                        challanNo[j] = temp_type;
                        // date sort
                        temp_type = date[i];
                        date[i] = date[j];
                        date[j] = temp_type;
                        // remarks sort
                        temp_type = remarks[i];
                        remarks[i] = remarks[j];
                        remarks[j] = temp_type;
                    }
                }
            }
        } // end of academic fee function
        static void display_academicFee()
        {
            sort_academicFee();
            Console.Write("Sr.No \tSemester type \tChallan no \tDate \tAmount \tRemarks");
            Console.Write("\n");
            for (int i = 0; i < increment_opAcademicFee; i++)
            {
                Console.Write(i + 1);
                Console.Write("\t");
                Console.Write(semesterType[i]);
                Console.Write("\t\t");
                Console.Write(challanNo[i]);
                Console.Write("\t\t");
                Console.Write(date[i]);
                Console.Write("\t");
                Console.Write(amountacademic[i]);
                Console.Write("\t");
                Console.Write(remarks[i]);
                Console.Write("\n");
            }
        } // end of display academic fee function
        static void sort_breakfast()
        {
            for (int i = 0; i < increment_opMealBreakfast; i++)
            {
                for (int j = i + 1; j < increment_opMealBreakfast; j++)
                {
                    if (chargesBreakfast[j] > chargesBreakfast[i])
                    {
                        float temp = chargesBreakfast[i];
                        chargesBreakfast[i] = chargesBreakfast[j];
                        chargesBreakfast[j] = temp;
                        //  menu sort
                        string temp_st = menuBreakfast[i];
                        menuBreakfast[i] = menuBreakfast[j];
                        menuBreakfast[j] = temp_st;
                        // remarks no sort
                        temp_st = remarksBreakfast[i];
                        remarksBreakfast[i] = remarksBreakfast[j];
                        remarksBreakfast[j] = temp_st;
                    }
                }
            }
        } // end of sorting breakfast function
        static void display_breakfast()
        {
            sort_breakfast();
            Console.Write("Sr.No \tBreakfast menu \tCharges\tRemarks");
            Console.Write("\n");
            for (int i = 0; i < increment_opMealBreakfast; i++)
            {
                Console.Write(i + 1);
                Console.Write("\t");
                Console.Write(menuBreakfast[i]);
                Console.Write("\t\t");
                Console.Write(chargesBreakfast[i]);
                Console.Write("\t");
                Console.Write(remarksBreakfast[i]);
                Console.Write("\n");
            }
        } // end of display breakfast function
        static void sort_lunch()
        {
            for (int i = 0; i < increment_opMealLunch; i++)
            {
                for (int j = i + 1; j < increment_opMealLunch; j++)
                {
                    if (chargesLunch[j] > chargesLunch[i])
                    {
                        float temp = chargesLunch[i];
                        chargesLunch[i] = chargesLunch[j];
                        chargesLunch[j] = temp;
                        //  menu sort
                        string temp_st = menuLunch[i];
                        menuLunch[i] = menuLunch[j];
                        menuLunch[j] = temp_st;
                        // remarks no sort
                        temp_st = remarksLunch[i];
                        remarksLunch[i] = remarksLunch[j];
                        remarksLunch[j] = temp_st;
                    }
                }
            }
        } // end of sort of lunch function
        static void display_lunch()
        {
            sort_lunch();
            Console.Write("Sr.No \tLunch menu \tCharges\tRemarks");
            Console.Write("\n");
            for (int i = 0; i < increment_opMealLunch; i++)
            {
                Console.Write(i + 1);
                Console.Write("\t");
                Console.Write(menuLunch[i]);
                Console.Write("\t\t");
                Console.Write(chargesLunch[i]);
                Console.Write("\t");
                Console.Write(remarksLunch[i]);
                Console.Write("\n");
            }
        } // end of display function
        static void sort_dinner()
        {
            for (int i = 0; i < increment_opMealDinner; i++)
            {
                for (int j = i + 1; j < increment_opMealDinner; j++)
                {
                    if (chargesDinner[j] > chargesDinner[i])
                    {
                        float temp = chargesDinner[i];
                        chargesDinner[i] = chargesDinner[j];
                        chargesDinner[j] = temp;
                        //  menu sort
                        string temp_st = menuDinner[i];
                        menuDinner[i] = menuDinner[j];
                        menuDinner[j] = temp_st;
                        // remarks no sort
                        temp_st = remarksDinner[i];
                        remarksDinner[i] = remarksDinner[j];
                        remarksDinner[j] = temp_st;
                    }
                }
            }
        } // end of sort dinner function
        static void display_dinner()
        {
            sort_dinner();
            Console.Write("Sr.No \tDinner menu \tCharges\tRemarks");
            Console.Write("\n");
            for (int i = 0; i < increment_opMealDinner; i++)
            {
                Console.Write(i + 1);
                Console.Write("\t");
                Console.Write(menuDinner[i]);
                Console.Write("\t\t");
                Console.Write(chargesDinner[i]);
                Console.Write("\t");
                Console.Write(remarksDinner[i]);
                Console.Write("\n");
            }
        } // display dinner function
          // ****************** FILE HANDLING ******************
            static string seperateField(string record, int field)
            {
                int comma = 1;
                string item = "";
                for (int x = 0; x < record.Length; x++)
                {
                    if (record[x] == ',')
                    {
                        comma++;
                    }
                    else if (comma == field)
                    {
                        item = item + record[x];
                    }
                }
                return item;
            }// end of function
        static void load_adminSecurityFile()
        {
            // File Handling
            StreamReader file = new StreamReader
            ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\adminSecurityFile.txt");
            string record;
            int i = 0;
            while ((record = file.ReadLine()) != null)
            {
                firstname[i] = seperateField(record, 1); // username field
                lastname[i] = seperateField(record, 2); // password field
                username[i] = seperateField(record, 3); // username field
                password[i] = seperateField(record, 4); // password field
                i++;
            }
            file.Close();
        } // end of function
        static void load_agentSecurityFile()
        {
            StreamReader file = new StreamReader
          ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\agentSecurityFile.txt");
            string record;
            int i = 0;
            while ((record = file.ReadLine()) != null)
            {
                firstname_Agent[i] = seperateField(record, 1); // create an account store firstname
                lastname_Agent[i] = seperateField(record, 2); // create an account store lastname
                username_Agent[i] = seperateField(record, 3); // username field
                password_Agent[i] = seperateField(record, 4); // password field
                i++;
            }
            file.Close();
        } // end of function
        static void load_agentWalletMoney()
        {
            StreamReader file = new StreamReader
         ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\agentWalletMoney.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                addWalletMoney = float.Parse((seperateField(record, 1)));
                walletRemarks = seperateField(record, 2);
            }
            file.Close();
        } // end of function
        static void load_admin3AcadmicFee()
        {
            StreamReader file = new StreamReader
         ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin3AcadmicFee.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                semesterType[increment_opAcademicFee] = seperateField(record, 1);
                challanNo[increment_opAcademicFee] = seperateField(record, 2);
                amountacademic[increment_opAcademicFee] = float.Parse((seperateField(record, 3)));
                date[increment_opAcademicFee] = seperateField(record, 4);
                remarks[increment_opAcademicFee] = seperateField(record, 5);
                increment_opAcademicFee++;
            }
            file.Close();
        } // end of function
        static void load_admin_4Hostel_1Meal_1Breakfast()
        {
            StreamReader file = new StreamReader
        ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_4Hostel_1Meal_1Breakfast.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                menuBreakfast[increment_opMealBreakfast] = seperateField(record, 1);
                chargesBreakfast[increment_opMealBreakfast] =float.Parse((seperateField(record, 2)));
                remarksBreakfast[increment_opMealBreakfast] = seperateField(record, 3);
                increment_opMealBreakfast++;
            }
            file.Close();
        } // end of function
        static void load_admin_4Hostel_1Meal_2Lunch()
        {
            StreamReader file = new StreamReader
      ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_4Hostel_1Meal_1Breakfast.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                menuLunch[increment_opMealLunch] = seperateField(record, 1);
                chargesLunch[increment_opMealLunch] = float.Parse((seperateField(record, 2)));
                remarksLunch[increment_opMealLunch] = seperateField(record, 3);
                increment_opMealLunch++;
            }
            file.Close();
        } // end of function
        static void load_admin_4Hostel_1Meal_3Dinner()
        {
            StreamReader file = new StreamReader
     ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_4Hostel_1Meal_3Dinner.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                menuDinner[increment_opMealDinner] = seperateField(record, 1);
                chargesDinner[increment_opMealDinner] =float.Parse((seperateField(record, 2)));
                remarksDinner[increment_opMealDinner] = seperateField(record, 3);
                increment_opMealDinner++;
            }
            file.Close();
        } // end of function
        static void load_admin_4Hostel_2MealChargesMonthly()
        {
            StreamReader file = new StreamReader
    ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_4Hostel_2MealChargesMonthly.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                monthlyMealExpenses[increment_opMealCharges] = seperateField(record, 1);
                chargesMealMonthly[increment_opMealCharges] = float.Parse((seperateField(record, 2)));
                remarksMealExpenses[increment_opMealCharges] = seperateField(record, 3);
                increment_opMealCharges++;
            }
            file.Close();
        } // end of function
        static void load_admin_4Hostel_3LivingChargesMonthly()
        {
            StreamReader file = new StreamReader
    ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_4Hostel_3LivingChargesMonthly.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                monthLivingExpenses[inc_opLivingCharges] = seperateField(record, 1);
                chargesLivingExpenses[inc_opLivingCharges] = float.Parse((seperateField(record, 2)));
                remarksLivingExpenses[inc_opLivingCharges] = seperateField(record, 3);
                inc_opLivingCharges++;
            }
            file.Close();
        }
        static void load_admin_4Hostel_4ServiceChargesMonthly()
        {
            StreamReader file = new StreamReader
   ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_4Hostel_4ServiceChargesMonthly.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                monthServiceExpenses[inc_opServiceCharges] = seperateField(record, 1);
                chargesServiceMonthly[inc_opServiceCharges] =float.Parse((seperateField(record, 2)));
                remarksServiceExpenses[inc_opServiceCharges] = seperateField(record, 3);
                inc_opServiceCharges++;
            }
            file.Close();
        }
        static void load_admin_4Hostel_5RenovationChargesMonthly()
        {
            StreamReader file = new StreamReader
      ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_4Hostel_5RenovationChargesMonthly.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                chargesRenovationMonthly[inc_opRenovationCharges] = float.Parse((seperateField(record, 1)));
                remarksRenovationExpenses[inc_opRenovationCharges] = seperateField(record, 2);
                inc_opRenovationCharges++;
            }
            file.Close();
        }
        static void load_admin_4Hostel_6LaundryChargesMonthly()
        {
            StreamReader file = new StreamReader
     ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_4Hostel_6LaundryChargesMonthly.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                chargesLaundryMonthly[inc_opLaundryCharges] = float.Parse((seperateField(record, 1)));
                remarksLaundryExpenses[inc_opLaundryCharges] = seperateField(record, 2);
                inc_opLaundryCharges++;
            }
            file.Close();
        }
        static void load_admin_4Hostel_7BarberChargesMonthly()
        {
            StreamReader file = new StreamReader
       ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_4Hostel_7BarberChargesMonthly.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                chargesBarberMonthly[inc_opBarberCharges] = float.Parse((seperateField(record, 1)));
                remarksBarberExpenses[inc_opBarberCharges] = seperateField(record, 2);
                inc_opBarberCharges++;
            }
            file.Close();
        }
        static void load_admin_5HelpingMaterial_1Notes()
        {
            StreamReader file = new StreamReader
          ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_5HelpingMaterial_1Notes.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                chargesNotesMonthly[inc_opNotesHelpingMaterial] = float.Parse((seperateField(record, 1)));
                remarksNotesExpenses[inc_opNotesHelpingMaterial] = seperateField(record, 2);
                inc_opNotesHelpingMaterial++;
            }
            file.Close();
        }
        static void load_admin_5HelpingMaterial_2Register()
        {
            StreamReader file = new StreamReader
            ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_5HelpingMaterial_2Register.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                chargesRegisterMonthly[inc_opRegisterHelpingMaterial] = float.Parse((seperateField(record, 1)));
                remarksRegisterExpenses[inc_opRegisterHelpingMaterial] = seperateField(record, 2);
                inc_opRegisterHelpingMaterial++;
            }
            file.Close();
        }
        static void load_admin_5HelpingMaterial_3Stationary()
        {
            StreamReader file = new StreamReader
              ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_5HelpingMaterial_3Stationary.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                chargesStationaryMonthly[inc_opStationaryHelpingMaterial] = float.Parse((seperateField(record, 1)));
                remarksStationaryExpenses[inc_opStationaryHelpingMaterial] = seperateField(record, 2);
                inc_opStationaryHelpingMaterial++;
            }
            file.Close();
        }
        static void load_admin_6RecreationalExpenses_1Friends()
        {
            StreamReader file = new StreamReader
              ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_6RecreationalExpenses_1Friends.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                chargesFriendsRecreationalExpenses[inc_opFriendsRecreationalExpenses] = float.Parse((seperateField(record, 1)));
                remarksFriendsRecreationalExpenses[inc_opFriendsRecreationalExpenses] = seperateField(record, 2);
                inc_opFriendsRecreationalExpenses++;
            }
            file.Close();
        }
        static void load_admin_6RecreationalExpenses_2Family()
        {
            StreamReader file = new StreamReader
               ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_6RecreationalExpenses_2Family.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                chargesFamilyRecreationalExpenses[inc_opFamilyRecreationalExpenses] = float.Parse((seperateField(record, 1)));
                remarksFamilyRecreationalExpenses[inc_opFamilyRecreationalExpenses] = seperateField(record, 2);
                inc_opFamilyRecreationalExpenses++;
            }
            file.Close();
        }
        static void load_admin_7CommunityFund_1Class()
        {
            StreamReader file = new StreamReader
              ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_7CommunityFund_1Class.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                remarksClassCommunityFund[inc_opClassCommunityFund] = seperateField(record, 1);
                chargesClassCommunityFund[inc_opClassCommunityFund] = float.Parse((seperateField(record, 2)));
                inc_opClassCommunityFund++;
            }
            file.Close();
        }
        static void load_admin_7CommunityFund_2Societies()
        {
            StreamReader file = new StreamReader
               ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_7CommunityFund_2Societies.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                remarksSocietiesCommunityFund[inc_opSocietiesCommunityFund] = seperateField(record, 1);
                chargesSocietiesCommunityFund[inc_opSocietiesCommunityFund] = float.Parse((seperateField(record, 2)));
                inc_opSocietiesCommunityFund++;
            }
            file.Close();
        }
        static void load_admin_8Goals_1Daily()
        {
            StreamReader file = new StreamReader
                ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_8Goals_1Daily.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                titleDailyGoals[inc_opDailyGoals] = seperateField(record, 1);
                descriptionDailyGoals[inc_opDailyGoals] = seperateField(record, 2);
                inc_opDailyGoals++;
            }
            file.Close();
        }
        static void load_admin_8Goals_2Weekly()
        {
            StreamReader file = new StreamReader
                  ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_8Goals_2Weekly.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                titleWeeklyGoals[inc_opWeeklyGoals] = seperateField(record, 1);
                descriptionWeeklyGoals[inc_opWeeklyGoals] = seperateField(record, 2);
                inc_opWeeklyGoals++;
            }
            file.Close();
        }
        static void load_admin_8Goals_3Monthly()
        {
            StreamReader file = new StreamReader
                  ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_8Goals_3Monthly.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                titleMonthlyGoals[inc_opMonthlyGoals] = seperateField(record, 1);
                descriptionMonthlyGoals[inc_opMonthlyGoals] = seperateField(record, 2);
                inc_opMonthlyGoals++;
            }
            file.Close();
        }
        static void load_admin_8Goals_4Yearly()
        {

            StreamReader file = new StreamReader
                  ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_8Goals_4Yearly.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                titleYearlyGoals[inc_opYearlyGoals] = seperateField(record, 1);
                descriptionYearlyGoals[inc_opYearlyGoals] = seperateField(record, 2);
                inc_opYearlyGoals++;
            }
            file.Close();
        }
        static void load_admin_9CellPhone_1Call()
        {
            StreamReader file = new StreamReader
                   ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_9CellPhone_1Call.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                nameCallPakage[inc_opCall_CellPhone] = seperateField(record, 1);
                amountCallPakage[inc_opCall_CellPhone] = float.Parse((seperateField(record, 2)));
                durationCallPakage[inc_opCall_CellPhone] = seperateField(record, 3);
                inc_opCall_CellPhone++;
            }
            file.Close();
        }
        static void load_admin_9CellPhone_2Internet()
        {
            StreamReader file = new StreamReader
                   ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_9CellPhone_2Internet.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                nameInternetPakage[inc_opInternet_CellPhone] = seperateField(record, 1);
                amountInternetPakage[inc_opInternet_CellPhone] = float.Parse((seperateField(record, 2)));
                durationInternetPakage[inc_opInternet_CellPhone] = seperateField(record, 3);
                inc_opInternet_CellPhone++;
            }
            file.Close();
        }
        static void load_admin_9CellPhone_3Message()
        {
            StreamReader file = new StreamReader
                    ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_9CellPhone_3Message.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                nameMessagePakage[inc_opMessage_CellPhone] = seperateField(record, 1);
                amountMessagePakage[inc_opMessage_CellPhone] = float.Parse((seperateField(record, 2)));
                durationMessagePakage[inc_opMessage_CellPhone] = seperateField(record, 3);
                inc_opMessage_CellPhone++;
            }
            file.Close();
        }
        static void load_admin_10Book_1Borrow()
        {
            StreamReader file = new StreamReader
                   ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_10Book_1Borrow.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                titleBorrowBook[inc_opBookBorrow] = seperateField(record, 1);
                authorBorrowBook[inc_opBookBorrow] = seperateField(record, 2);
                friendnameBorrowBook[inc_opBookBorrow] = seperateField(record, 3);
                remarksBorrowBook[inc_opBookBorrow] = seperateField(record, 4);
                inc_opBookBorrow++;
            }
            file.Close();
        }
        static void load_admin_10Book_2Purchase()
        {
            StreamReader file = new StreamReader
                  ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_10Book_2Purchase.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                titlePurchaseBook[inc_opBookPurchase] = seperateField(record, 1);
                authorPurchaseBook[inc_opBookPurchase] = seperateField(record, 2);
                amountPurchaseBook[inc_opBookPurchase] = float.Parse((seperateField(record, 3)));
                remarksPurchaseBook[inc_opBookPurchase] = seperateField(record, 4);
                inc_opBookPurchase++;
            }
            file.Close();
        }
        static void load_admin_11SelfMotivational_1FiveTimePrayer()
        {
            StreamReader file = new StreamReader
                     ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_11SelfMotivational_1FiveTimePrayer.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                five_time_Prayer[inc_opFiveTimePrayer] = seperateField(record, 1);
                inc_opFiveTimePrayer++;
            }
            file.Close();
        }
        static void load_admin_11SelfMotivational_2Quran_e_Pak()
        {
            StreamReader file = new StreamReader
                     ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_11SelfMotivational_2Quran_e_Pak.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                Quran_e_Pak[inc_opQuran_e_Pak] = seperateField(record, 1);
                inc_opQuran_e_Pak++;
            }
            file.Close();
        }
        static void load_admin_11SelfMotivational_3Durood_e_Pak()
        {
            StreamReader file = new StreamReader
                     ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_11SelfMotivational_3Durood_e_Pak.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                Durood_e_Pak[inc_opDurood_e_Pak] = seperateField(record, 1);
                inc_opDurood_e_Pak++;
            }
            file.Close();
        }
        static void load_admin_12Transport_1Uber()
        {
            StreamReader file = new StreamReader
                      ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_12Transport_1Uber.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                locationFromUber[inc_opUberTransport] = seperateField(record, 1);
                locationToUber[inc_opUberTransport] = seperateField(record, 2);
                amountUber[inc_opUberTransport] = float.Parse((seperateField(record, 3)));
                purposeUber[inc_opUberTransport] = seperateField(record, 4);
                inc_opUberTransport++;
            }
            file.Close();
        }
        static void load_admin_12Transport_2Bus()
        {
            StreamReader file = new StreamReader
            ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_12Transport_2Bus.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                locationFromBus[inc_opBusTransport] = seperateField(record, 1);
                locationToBus[inc_opBusTransport] = seperateField(record, 2);
                amountBus[inc_opBusTransport] = float.Parse((seperateField(record, 3)));
                purposeBus[inc_opBusTransport] = seperateField(record, 4);
                inc_opBusTransport++;
            }
            file.Close();
        }
        static void load_admin_13RecreationalActivities_1Sporties()
        {
            StreamReader file = new StreamReader
              ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_13RecreationalActivities_1Sporties.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                minutiesSporties[inc_opSportiesActivities] = float.Parse((seperateField(record, 1)));
                inc_opSportiesActivities++;
            }
            file.Close();
        }
        static void load_admin_13RecreationalActivities_2Socities()
        {
            StreamReader file = new StreamReader
            ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_13RecreationalActivities_2Socities.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                minutiesSocieties[inc_opSocietiesActivities] = float.Parse((seperateField(record, 1)));
                purposeSocieties[inc_opSocietiesActivities] = seperateField(record, 2);
                inc_opSocietiesActivities++;
            }
            file.Close();
        }
        static void load_admin_14Achievments_1CoCurricular()
        {
            StreamReader file = new StreamReader
             ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_14Achievments_1CoCurricular.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                awardCo_Curricular[inc_opCoCurricular] = seperateField(record, 1);
                presentCo_Curricular[inc_opCoCurricular] = seperateField(record, 2);
                remarksCo_Curricular[inc_opCoCurricular] = seperateField(record, 3);
                inc_opCoCurricular++;
            }
            file.Close();
        }
        static void load_admin_14Achievments_2ExtraCurricular()
        {
            StreamReader file = new StreamReader
            ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_14Achievments_2ExtraCurricular.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                awardExtra_Curricular[inc_opExtraCurricular] = seperateField(record, 1);
                presentExtra_Curricular[inc_opExtraCurricular] = seperateField(record, 2);
                remarksExtra_Curricular[inc_opExtraCurricular] = seperateField(record, 3);
                inc_opExtraCurricular++;
            }
            file.Close();
        }
        static void load_admin_15ResultGrades()
        {
            StreamReader file = new StreamReader
            ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_15ResultGrades.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                gpa[inc_opResultGrades] = float.Parse((seperateField(record, 1)));
                cgpa[inc_opResultGrades] = float.Parse((seperateField(record, 2)));
                remarksResult[inc_opResultGrades] = seperateField(record, 3);
                inc_opResultGrades++;
            }
            file.Close();
        }
        static void load_admin_16GoldenLines()
        {
            StreamReader file = new StreamReader
             ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_16GoldenLines.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                titleGoldenLines[inc_opGoldenLines] = seperateField(record, 1);
                descriptionGoldenLines[inc_opGoldenLines] = seperateField(record, 2);
                inc_opGoldenLines++;
            }
            file.Close();
        }
        static void load_admin_17LifelongEvents()
        {
            StreamReader file = new StreamReader
            ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_17LifelongEvents.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                titleLifelongEvents[inc_opLifelongEvents] = seperateField(record, 1);
                descriptionLifelongEvents[inc_opLifelongEvents] = seperateField(record, 2);
                inc_opLifelongEvents++;
            }
            file.Close();
        }
        static void load_admin_18Notes()
        {
            StreamReader file = new StreamReader
            ("D:\\COMPUTER SCIENCE\\PD\\Business Application\\University Student Diary Management System\\Version_1\\USDMSVersion01\\File Handling\\admin_18Notes.txt");
            string record;
            while ((record = file.ReadLine()) != null)
            {
                titleNotes[inc_opNotes] = seperateField(record, 1);
                descriptionNotes[inc_opNotes] = seperateField(record, 2);
                inc_opNotes++;
            }
            file.Close();
        }
        //****************** VALIDATIONS ******************
        static float float_Validaion(string about, string variable)
        {
            float temp;
            while(!float.TryParse(variable ,out temp)) // check the validation of correct data type
            {
                Console.Write("Invalid entry.Please reenter.");
                Console.Write("\n");
                Console.Write(about);
                variable=Console.ReadLine();
            }
            return float.Parse(variable);
        }
        //********************************************************************************** END OF PROGEAM CODE *********************************************************************
    }
}
