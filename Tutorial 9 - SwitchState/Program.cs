int month = 5;
string monthName = "";

switch (month)
{
	case 1:
		monthName = "January";
		break;
	case 2:
		monthName = "February";
		break;
	case 3:
		monthName = "March";
		break;
	default:
		monthName = "Unknown";
		break;
}

Console.WriteLine("The current month is " + monthName);
