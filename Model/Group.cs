using SQLite;
using System;

namespace RegistrationApp.Model
{
    public class Group
    {
        [PrimaryKey, AutoIncrement]
        public int GroupId { get; set; }
        private int databaseId;
        [Indexed]
        public int DatabaseId
        {
            get { return databaseId; }
            set
            {
                databaseId = value;
            }
        }
        private DateTime createdTime;
        public DateTime CreatedTime
        {
            get { return createdTime; }
            set { createdTime = value; }
        }

        private DateTime updatedTime;
        public DateTime UpdatedTime
        {
            get { return updatedTime; }
            set { updatedTime = value; }
        }
        private string timeStamp = "";
        public string TimeStamp { get { return timeStamp; } set { timeStamp = value; } }

        private string durationFrom = "";
        public string DurationFrom { get { return durationFrom; } set { durationFrom = value; } }

        private string durationTo = "";
        public string DurationTo { get { return durationTo; } set { durationTo = value; } }

        private string gender = "";
        public string Gender { get { return gender; } set { gender = value; } }

        private string name = "";
        public string Name { get { return name; } set { name = value; } }

        private string surname = "";

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        private string ordinationName = "";

        public string OrdinationName
        {
            get { return ordinationName; }
            set { ordinationName = value; }
        }

        private string passportNumber = "";
        public string PassportNumber { get { return passportNumber; } set { passportNumber = value; } }

        private string country = "";

        public string Country { get { return country; } set { country = value; } }

        private int numberOfPeople = 0;
        public int NumberOfPeople
        {
            get { return numberOfPeople; }
            set { numberOfPeople = value; }
        }

        private int maleMonastic = 0;
        public int MaleMonastic
        {
            get { return maleMonastic; }
            set { maleMonastic = value; }
        }

        private int femaleMonastic = 0;
        public int FemaleMonastic
        {
            get { return femaleMonastic; }
            set { femaleMonastic = value; }
        }

        private int male = 0;
        public int Male
        {
            get { return male; }
            set
            {
                male = value;
            }
        }
        private int female = 0;
        public int Female
        {
            get { return female; }
            set
            {
                female = value;
            }
        }

        private string specialInformation = "";
        public string SpecialInformation
        {
            get { return specialInformation; }
            set { specialInformation = value; }
        }

        private int maleLessThan18 = 0;
        public int MaleLessThan18
        {
            get { return maleLessThan18; }
            set { maleLessThan18 = value; }
        }

        private int femaleLessThan18 = 0;
        public int FemaleLessThan18
        {
            get
            {
                return femaleLessThan18;
            }
            set
            {
                femaleLessThan18 = value;
            }
        }

        private int maleElders1 = 0;
        public int MaleElders1
        {
            get { return maleElders1; }
            set
            {
                maleElders1 = value;
            }
        }

        private int femaleElders1 = 0;
        public int FemaleElders1
        {
            get { return femaleElders1; }

            set { femaleElders1 = value; }
        }

        private int maleElders2 = 0;
        public int MaleElders2
        {
            get { return maleElders2; }
            set
            {
                maleElders2 = value;
            }
        }

        private int femaleElders2 = 0;
        public int FemaleElders2
        {
            get { return femaleElders2; }

            set { femaleElders2 = value; }
        }

        private int maleWheelChair = 0;
        public int MaleWheelChair
        {
            get { return maleWheelChair; }
            set { maleWheelChair = value; }
        }

        private int femaleWheelChair = 0;
        public int FemaleWheelChair
        {
            get { return femaleWheelChair; }
            set { femaleWheelChair = value; }
        }

        private string covidCertificates = "";
        public string CovidCertificates
        {
            get { return covidCertificates; }
            set { covidCertificates = value; }

        }


        private string passportPicture = "";
        public string PassportPicture
        {
            get { return passportPicture; }
            set { passportPicture = value; }

        }

        private string transportation = "";
        public string Transportation
        {
            get { return transportation; }
            set { transportation = value; }

        }

        private string dateForPickupA = "";
        public string DateForPickupA
        {
            get { return dateForPickupA; }
            set { dateForPickupA = value; }
        }

        private string pickupTimeA = "";
        public string PickupTimeA
        {
            get { return pickupTimeA; }
            set { pickupTimeA = value; }
        }

        private string pickupPlaceA = "";
        public string PickupPlaceA
        {
            get { return pickupPlaceA; }
            set
            {
                pickupPlaceA = value;
            }
        }

        private string airtickets = "";
        public string Airtickets
        {
            get { return airtickets; }
            set
            {
                airtickets = value;
            }
        }

        private string flightNOTime = "";
        public string FlightNoTime
        {
            get { return flightNOTime; }
            set
            {
                flightNOTime = value;
            }
        }

        private string nameOfPlace = "";
        public string NameOfPlace
        {
            get { return nameOfPlace; }
            set
            {
                nameOfPlace = value;
            }
        }

        private string addressOfPlace = "";
        public string AddressOfPlace { get { return addressOfPlace; } set { addressOfPlace = value; } }

        private string booking = "";
        public string Booking { get { return booking; } set { booking = value; } }

        private string departureDateFromBangkok = "";
        public string DepartureDateFromBangkok
        {
            get { return departureDateFromBangkok; }
            set
            {
                departureDateFromBangkok = value;
            }
        }

        private string bangkokPickupTime = "";
        public string BangkokPickupTime { get { return bangkokPickupTime; } set { bangkokPickupTime = value; } }

        private string departureTransportation = "";
        public string DepartureTransportation
        {
            get { return departureTransportation; }
            set { departureTransportation = value; }
        }

        private string dateForPickupD = "";
        public string DateForPickupD
        {
            get { return dateForPickupD; }
            set { dateForPickupD = value; }
        }

        private string pickupTimeD = "";
        public string PickupTimeD
        {
            get { return pickupTimeD; }
            set { pickupTimeD = value; }
        }

        private string placeD = "";
        public string PlaceD
        {
            get { return placeD; }
            set
            {
                placeD = value;
            }
        }

        private string email = "";
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string lineID = "";
        public string LineID { get { return lineID; } set { lineID = value; } }

        private string whatsappID = "";
        public string WhatsappID { get { return whatsappID; } set { whatsappID = value; } }

        private string kakaotalkID = "";
        public string KakaotalkID { get { return kakaotalkID; } set { kakaotalkID = value; } }

        private string wechatID = "";
        public string WechatID { get { return wechatID; } set { wechatID = value; } }

        private string phoneNO = "";
        public string PhoneNO
        {
            get { return phoneNO; } set { phoneNO = value; } 
        }

        private string googleform = "";
        public string Googleform { get { return googleform; } set { googleform = value; } }

        private string emergencyContact = "";
        public string EmergencyContatct { get { return emergencyContact; } set { emergencyContact = value; } }

        private string vaccinationStatus = "";
        public string VaccinationStatus { get { return vaccinationStatus; } set { vaccinationStatus = value; } }

        private string moreThan90Days = "";
        public string MoreThan90Days { get { return moreThan90Days; } set { moreThan90Days = value; } }

        private string remind3DaysBeforeA = "";
        public string Remind3DaysBeforeA { get { return remind3DaysBeforeA; } set { remind3DaysBeforeA = value; } }

        private string covidTest = "";
        public string CovidTest
        {
            get { return covidTest; }
            set { covidTest = value; }
        }

        private string filelocation = "";
        public string Filelocation { get { return filelocation; } set { filelocation = value; } }

    }
}