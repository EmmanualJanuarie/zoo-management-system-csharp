using System;
using System.Threading;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Media;
using System.Windows.Forms;
using static ZooManagementSystem.frmGuestMenu.Lion;

namespace ZooManagementSystem
{

    // Define the enums for AnimalType, FoodType, and HabitatType
    #region "Enum for Animal Type"
    public enum AnimalType
    {
        Lion,
        Hyena,
        Zebra,
        Elephant,
        Warthog,
        Apes
    }

    #endregion

    #region "Enum for Food Type"
    public enum FoodType//enum for FoodType
    {
        Meat,
        Vegetation,
        Mixed,
    }
    #endregion

    #region "Enum for Habitat type"
    public enum HabitatType//Enum for Habitat type
    {
        Savanna,
        Forest,
        Jungle,
    } 
    #endregion

    public partial class frmGuestMenu : Form
    {
        private Animal selectedAnimal;
        private DietInfo selectedAnimalDiet;

        
        public frmGuestMenu()
        {
            InitializeComponent();
        }

        //Define Struct for habitat info
        #region "Struct fot Animal Habitat Info"
        public struct HabitatInfo
        {
            public HabitatType habitatType;
        }

        #endregion

        // Define the DietInfo struct
        #region "Struct for Animal Dietary Info"
        public struct DietInfo
        {
            public FoodType DietaryRequirements;
            public string FeedingSchedule;
        } 
        #endregion

        private void btnToMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frmMainMenu = new frmMainMenu();//creating object of class FrmMainMenu
            frmMainMenu.Show();//directing user back to mainmenu
            this.Hide();//hides this form
        }

        private void frmGuestMenu_Load(object sender, EventArgs e)
        {
            SoundPlayer music = new SoundPlayer(@"C:\Users\emman\OneDrive\Desktop\Emmanual_Januarie_20230432_PRG521_FA3\ZooManagementSystem\src\Sounds\Lion_Sleeps_Tonight.wav");//careating an object of library 
            music.Stop();//stops the music when this form loads 

            // Populate the combo box with the types of animals.
            cmbAnimal.Items.Add("Lion");//adding Lion
            cmbAnimal.Items.Add("Hyena");//adding Hyena
            cmbAnimal.Items.Add("Zebra");//adding Zebra
            cmbAnimal.Items.Add("Elephant");//adding Elephant
            cmbAnimal.Items.Add("Warthog");//adding Warthog
            cmbAnimal.Items.Add("Apes");//adding Apes

            // Populate the combo box with the types of Location
            cmbLocation.Items.Add("Block A");//adding Block A
            cmbLocation.Items.Add("Block B");//adding Block B
            cmbLocation.Items.Add("Block C");//adding Block C

            // Populate the combo box with the types of Species
            cmbSpecies.Items.Add("Carnivores");//adding Block A
            cmbSpecies.Items.Add("Herbivores");//adding Block B
            cmbSpecies.Items.Add("Omnivores");//adding Block C
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void grpGuestSelect_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the cmbAnimal control.
        /// This method retrieves the selected animal from the combo box, determines its diet and habitat information based on its type,
        /// and then displays this information in the lstVirtualAnimal list box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>

        private void cmbAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Parse the selected animal from the combo box
            AnimalType selectedAnimal = (AnimalType)Enum.Parse(typeof(AnimalType), cmbAnimal.SelectedItem.ToString());

            // Initialize diet and habitat info objects
            DietInfo selectedAnimalDiet = new DietInfo ();
            HabitatInfo selectedAnimalHabitat = new HabitatInfo();

            // Switch case to handle different animal types
            switch (selectedAnimal)
            {
                case AnimalType.Lion:
                    // Set diet and habitat info for Lion
                    selectedAnimalDiet = new DietInfo { DietaryRequirements = FoodType.Meat, FeedingSchedule = "Twice a day (Beef, Chicken or Rabbit)" };
                    selectedAnimalHabitat = new HabitatInfo { habitatType = HabitatType.Savanna };
                    break;
                case AnimalType.Hyena:
                    // Set diet and habitat info for Hyena
                    selectedAnimalDiet = new DietInfo { DietaryRequirements = FoodType.Meat, FeedingSchedule = "Small bones for dental growth and Meat" };
                    selectedAnimalHabitat = new HabitatInfo { habitatType = HabitatType.Savanna };
                    break;
                case AnimalType.Zebra:
                    // Set diet and habitat info for Zebra
                    selectedAnimalDiet = new DietInfo { DietaryRequirements = FoodType.Vegetation, FeedingSchedule = "Morning: Grazing on fresh grass" };
                    selectedAnimalHabitat = new HabitatInfo { habitatType = HabitatType.Savanna };
                    break;
                case AnimalType.Elephant:
                    // Set diet and habitat info for Zebra
                    selectedAnimalDiet = new DietInfo { DietaryRequirements = FoodType.Vegetation, FeedingSchedule = "Fresh Branches, leaves and some fruit" };
                    selectedAnimalHabitat = new HabitatInfo { habitatType = HabitatType.Forest };
                    break;
                case AnimalType.Warthog:
                    // Set diet and habitat info for Warthog
                    selectedAnimalDiet = new DietInfo { DietaryRequirements = FoodType.Mixed, FeedingSchedule = "Fruit, alfalfa hay, carrots, some termites, ants or beetles" };
                    selectedAnimalHabitat = new HabitatInfo { habitatType = HabitatType.Savanna };
                    break;
                case AnimalType.Apes:
                    // Set diet and habitat info for Apes
                    selectedAnimalDiet = new DietInfo { DietaryRequirements = FoodType.Mixed, FeedingSchedule = "fresh fruit and vegtables, Midday(Biscuits or insects)" };
                    selectedAnimalHabitat = new HabitatInfo { habitatType = HabitatType.Jungle };
                    break;
            }

            // Add the selected animal's diet and habitat info to the list box
            lstVirtualAnimal.Items.Add("Feeding Schedule:" + selectedAnimalDiet.FeedingSchedule);
            lstVirtualAnimal.Items.Add("Dietary Requirements:" + selectedAnimalDiet.DietaryRequirements);
            lstVirtualAnimal.Items.Add("Animal Habitat:" + selectedAnimalHabitat.habitatType);
        }


        #region "Designing Abstract class Animal"
        public abstract class Animal//base class animal
        {
            public abstract void Eat(string food, int quantity);//overloaded abstract method
            public abstract string Feed();//abstract method Feed
            public abstract string Move();//abstract method Move
            public abstract string Speak();//abstract method Speak
            public abstract void Walk();//abstract method Walk
            public abstract void Sleep();//abstract method Sleep


        } 
        #endregion

        //creating animal class for Lion
        public class Lion : Animal, IClimbing//derived class Lion inheriting from Animalp
        {
            private string _food; // Private field for lion's food
            private int _quantity; // Private field for lion's food quantity

            // Property for _food with get and set
            public string Food
            {
                get { return _food; }
                set
                {
                    if (value != null)
                        _food = value;
                    else
                        throw new ArgumentException("Food must not be null");
                }
            }

            // Property for _quantity with get and set
            public int Quantity
            {
                get { return _quantity; }
                set
                {
                    if (value > 0)
                        _quantity = value;
                    else
                        throw new ArgumentException("Quantity must be greater than 0");
                }
            }
            public Lion(string food, int quantity)
            {
                this.Food = food;
                this.Quantity = quantity;
            }

            public override string Move()//Abstract Method Move
            {
                return "Lion is about to move.";
            }
            public override void Walk()//using override key word to overwrite method Walk
            {
                Console.WriteLine("Lion is walking");//displaying overwritten text
            }

            public override void Sleep()//using override key word to overwrite method sleep
            {
                Console.WriteLine("Lion is sleeping");//displaying overwritten text
            }
            //polymorphism shown with method feed [did used use specific subclass]
            public override string Feed()//Abstract Method Feed
            {
                return "Lion is being fed.";
            }
           
            public override void Eat(string food, int quantity)//using override key word to overwrite method Eat
            {
                Console.WriteLine($"The Lion eats {quantity} {food}.");//displaying overwritten text
            }


            public override string Speak()//Abstract Method Speak
            {
                SoundPlayer lionSound = new SoundPlayer(@"C:\Users\emman\OneDrive\Desktop\Emmanual_Januarie_20230432_PRG521_FA3\ZooManagementSystem\src\Sounds\lionRoar.wav");//careating an object of library 
                lionSound.Play();
                return "Roar";
            }

            //creating method for lion climbing
            public string Climb()
            {
                return "Lion is climbing onto rock...";
            }

            //creating animal class for Hyena
            public class Hyena : Animal, IClimbing//derived class Hyena inheriting from Animal
            {
                private string _food; // Private field for Hyena's food
                private int _quantity; // Private field for Hyena's food quantity

                // Property for _food with get and set
                public string Food
                {
                    get { return _food; }
                    set
                    {
                        if (value != null)
                            _food = value;
                        else
                            throw new ArgumentException("Food must not be null");
                    }
                }

                // Property for _quantity with get and set
                public int Quantity
                {
                    get { return _quantity; }
                    set
                    {
                        if (value > 0)
                            _quantity = value;
                        else
                            throw new ArgumentException("Quantity must be greater than 0");
                    }
                }
                public Hyena(string food, int quantity)
                {
                    this.Food= food;
                    this.Quantity = quantity;
                }

                public override string Move()//Abstract Method Move
                {
                    return  "Hyena is about to move.";
                }
                public override void Walk()//using override key word to overwrite method Walk
                {
                    Console.WriteLine("Hyena is walking");//displaying overwritten text
                }

                public override void Sleep()//using override key word to overwrite method sleep
                {
                    Console.WriteLine("Hyena is sleeping");//displaying overwritten text
                }

   
                public override string Feed()//Abstract Method Feed
                {
                    return "Hyena is being fed.";
                }
 
                public override void Eat(string food, int quantity)//using override key word to overwrite method Eat
                {
                    Console.WriteLine($"The Hyena eats {quantity} {food}.");//displaying overwritten text
                }
                //polymorphism shown with method sound [did used use specific subclass]
                public override string Speak()//Abstract Method Speak
                {
                    SoundPlayer hyenaSound = new SoundPlayer(@"C:\Users\emman\OneDrive\Desktop\Emmanual_Januarie_20230432_PRG521_FA3\ZooManagementSystem\src\Sounds\hyenaSound.wav");//careating an object of library 
                    hyenaSound.Play();
                    return "Hyena Laugh!";
                }

                //creating method for Hyena climbing
                public string Climb()
                {
                    return "Hyena is climbing onto dead log...";
                }
            }

            //creating animal class for Zebra
            public class Zebra : Animal, IOtherActions//derived class Zebra inheriting from Animal
            {
                private string _food; // Private field for Zebra's food
                private int _quantity; // Private field for Zebra's food quantity

                // Property for _food with get and set
                public string Food
                {
                    get { return _food; }
                    set
                    {
                        if (value != null)
                            _food = value;
                        else
                            throw new ArgumentException("Food must not be null");
                    }
                }

                // Property for _quantity with get and set
                public int Quantity
                {
                    get { return _quantity; }
                    set
                    {
                        if (value > 0)
                            _quantity = value;
                        else
                            throw new ArgumentException("Quantity must be greater than 0");
                    }
                }
                public Zebra(string food, int quantity)
                {
                    this.Food = food;
                    this.Quantity = quantity;
                }

                public override string Move()//abstract method move
                {
                    return "Zebra is about to move.";
                }
                public override void Walk()//using override key word to overwrite method Walk
                {
                    Console.WriteLine("Zebra is walking");//displaying overwritten text
                }

                public override void Sleep()//using override key word to overwrite method sleep
                {
                    Console.WriteLine("Zebra is sleeping");//displaying overwritten text
                }

                public override string Feed()//abstract method Feed
                {
                    return "Zebra is being fed.";
                }
                public override void Eat(string food, int quantity)//using override key word to overwrite method Eat
                {
                    Console.WriteLine($"The Zebra eats {quantity} {food}.");//displaying overwritten text
                }

                public override string Speak()//abstract method Speak
                {
                    SoundPlayer zebraSound = new SoundPlayer(@"C:\Users\emman\OneDrive\Desktop\Emmanual_Januarie_20230432_PRG521_FA3\ZooManagementSystem\src\Sounds\zebraSound.wav");//careating an object of library 
                    zebraSound.Play();
                    return "Laughing Zebra sound!";
                }

                //creating method for Zebra Jumping
                public string OtherAction()
                {
                    return "Zebra jump over rock.";
                }


            }

            //creating animal class for Elephant
            public class Elephant : Animal, IOtherActions//derived class Elephant inheriting from Animal
            {
                private string _food; // Private field for Elephant's food
                private int _quantity; // Private field for Elephant's food quantity

                // Property for _food with get and set
                public string Food
                {
                    get { return _food; }
                    set
                    {
                        if (value != null)
                            _food = value;
                        else
                            throw new ArgumentException("Food must not be null");
                    }
                }

                // Property for _quantity with get and set
                public int Quantity
                {
                    get { return _quantity; }
                    set
                    {
                        if (value > 0)
                            _quantity = value;
                        else
                            throw new ArgumentException("Quantity must be greater than 0");
                    }
                }
                public Elephant(string food, int quantity)
                {
                    this.Food = food;
                    this.Quantity = quantity;
                }
                public override string Move()//Abstract Method Move
                {
                    return "Elephant is about to move.";
                }
                public override void Walk()//using override key word to overwrite method Walk
                {
                    Console.WriteLine("Elephant is Stomping");//displaying overwritten text
                }


                public override void Sleep()//using override key word to overwrite method sleep
                {
                    Console.WriteLine("Elephant is sleeping");//displaying overwritten text
                }

  
                public override string Feed()//Abstract Method Feed
                {
                    return "Elephant is being fed.";
                }
           
                public override void Eat(string food, int quantity)//using override key word to overwrite method Eat
                {
                    Console.WriteLine($"The Elephant eats {quantity} {food}.");//displaying overwritten text
                }
                //polymorphism shown with method sound [did not use specific subclass]
                public override string Speak()//Abstract Method Speak
                {
                    SoundPlayer elephantSound = new SoundPlayer(@"C:\Users\emman\OneDrive\Desktop\Emmanual_Januarie_20230432_PRG521_FA3\ZooManagementSystem\src\Sounds\elephantSound.wav");//careating an object of library 
                    elephantSound.Play();
                    return "toot! toot!";
                }

                //creating method for Hyena climbing
                public string OtherAction()
                {
                    return "Elephant spraying water out of trunk.";
                }
            }

            //creating animal class for WARTHOG
            public class Warthog : Animal, ISwimming//derived class Warthog inheriting from Animal
            {
                private string _food; // Private field for Warthog's food
                private int _quantity; // Private field for Warthog's food quantity

                // Property for _food with get and set
                public string Food
                {
                    get { return _food; }
                    set
                    {
                        if (value != null)
                            _food = value;
                        else
                            throw new ArgumentException("Food must not be null");
                    }
                }

                // Property for _quantity with get and set
                public int Quantity
                {
                    get { return _quantity; }
                    set
                    {
                        if (value > 0)
                            _quantity = value;
                        else
                            throw new ArgumentException("Quantity must be greater than 0");
                    }
                }
                public Warthog(string food, int quantity)
                {
                    this.Food = food;
                    this.Quantity = quantity;
                }
                public override string Move()//Abstract Method Move
                {
                    return "Warthog is about to move.";
                }
                public override void Walk()//using override key word to overwrite method Walk
                {
                    Console.WriteLine("Warthog is walking");//displaying overwritten text
                }

                public override void Sleep()//using override key word to overwrite method sleep
                {
                    Console.WriteLine("Warthog is sleeping");//displaying overwritten text
                }

  
                public override string Feed()//Abstract Method Feed
                {
                    return "Warthog is being fed.";
                }
               

                public override void Eat(string food, int quantity)//using override key word to overwrite method Eat
                {
                    Console.WriteLine($"The Warthog eats {quantity} {food}.");//displaying overwritten text
                }

    
                public override string Speak()//Abstract Method Speak
                {
                    SoundPlayer warthogSound = new SoundPlayer(@"C:\Users\emman\OneDrive\Desktop\Emmanual_Januarie_20230432_PRG521_FA3\ZooManagementSystem\src\Sounds\warthogSound.wav");//careating an object of library 
                    warthogSound.Play();
                    return "Deep oink!";
                }

                //creating method for Hyena climbing
                public string Swim()
                {
                    return "Warthog swimming in watering hole.";
                }
            }

            //creating animal class for Elephant
            public class Apes : Animal,IClimbing//derived class Apes inheriting from Animal
            {
                private string _food; // Private field for Apes's food
                private int _quantity; // Private field for Apes's food quantity

                // Property for _food with get and set
                public string Food
                {
                    get { return _food; }
                    set
                    {
                        if (value != null)
                            _food = value;
                        else
                            throw new ArgumentException("Food must not be null");
                    }
                }

                // Property for _quantity with get and set
                public int Quantity
                {
                    get { return _quantity; }
                    set
                    {
                        if (value > 0)
                            _quantity = value;
                        else
                            throw new ArgumentException("Quantity must be greater than 0");
                    }
                }
                public Apes(string food, int quantity)
                {
                    this.Food = food;
                    this.Quantity = quantity;
                }
                //polymorphism shown with method move [did not use specific subclass]
                public override string Move()//Abstract Method Move
                {
                    return "Apes is about to move.";
                }
                public override void Walk()//using override key word to overwrite method Walk
                {
                    Console.WriteLine("Ape is walking");//displaying overwritten text
                }

                public override void Sleep()//using override key word to overwrite method sleep
                {
                    Console.WriteLine("Ape is sleeping");//displaying overwritten text
                }

  
                public override string Feed()//Abstract Method Feed
                {
                    return "Ape is being fed.";
                }
               

 
                public override void Eat(string food, int quantity)//using override key word to overwrite method Eat
                {
                    Console.WriteLine($"The Ape eats {quantity} {food}.");//displaying overwritten text
                }
                //polymorphism shown with method sound [did not use specific subclass]
                public override string Speak()//Interface method [Sound]
                {
                    SoundPlayer apeSound = new SoundPlayer(@"C:\Users\emman\OneDrive\Desktop\Emmanual_Januarie_20230432_PRG521_FA3\ZooManagementSystem\src\Sounds\apeSound.wav");//careating an object of library 
                    apeSound.Play();
                    return "Ape noises!";
                }

                //creating method for Hyena climbing
                public string Climb()
                {
                    return "APE is climbing up a tree.";
                }

            }

            private void btnFeed_Click(object sender, EventArgs e)
            {
                //Feed the selected animal


            }

            #region "Designing of Interfaces"
            //creating interfaces 
            public interface IClimbing//interface created to simulate animals climbing
            {
                string Climb();
            }

            public interface ISwimming//interface created to simulate animals swimming
            {
                string Swim();
            }

            public interface IOtherActions//interface created to simulate animals other action
            {
                string OtherAction();
            } 
            #endregion


        }

        protected Dictionary<string, Animal> animalDict;

        #region "Generates animal Feeding based on input"
        private void btnFedAnimal_Click(object sender, EventArgs e)
        {
            IsCorrectSelection_btnFeed();
        }
        #endregion

        #region "Generates animal movement"
        public void moveAnimal(Animal animalObj)
        {
            //Displays message to listbox stating that animal moved
            string result = animalObj.Move();
            lstVirtualAnimal.Items.Add(result);
        }
        #endregion

        #region "Simulates animal movement when button is clicked"
        private void btnMove_Click(object sender, EventArgs e)
        {
            IsCorrectSelection_btnMove();//calling method [Error handelling]
        } 
        #endregion

        #region "Generates sound of selected Animal"

        private void btnSound_Click(object sender, EventArgs e)
        {
            IsCorrectSelection_btnSound();//calling method [Error handelling]
        }
        #endregion


        private void btnEat_Click(object sender, EventArgs e)
        {
            IsCorrectSelection_btnEat();//calling method [Error handelling]
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtFood.Clear();
            txtFoodQuantity.Clear();
            lstVirtualAnimal.Items.Clear();
        }

        private void cmbSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            //displays what's selected from combo box to listbox
            if (cmbSpecies.SelectedIndex == 0)
            {
                lstVirtualAnimal.Items.Add("You've chosen the carnivore, Please select carnivores!");//displayed when first option is selected
            }else if (cmbSpecies.SelectedIndex == 1)
            {
                lstVirtualAnimal.Items.Add("You've chosen the Herbivore, Please select herbivores!");//displayed when second option is selected
            }
            else if (cmbSpecies.SelectedIndex == 2)
            {
                lstVirtualAnimal.Items.Add("You've chosen the omnivore, Please select omnivores!");//displayed when Third option is selected
            }
        }

        private void cmbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //displays what's selected from combo box to listbox
            if (cmbLocation.SelectedIndex == 0)
            {
                lstVirtualAnimal.Items.Add("You've chosen the Block A - carnivore location, Please select carnivores!");//displayed when first option is selected
            }
            else if (cmbLocation.SelectedIndex == 1)
            {
                lstVirtualAnimal.Items.Add("You've chosen the Block B - herbivore location, Please select herbivores!");//displayed when second option is selected
            }
            else if (cmbLocation.SelectedIndex == 2)
            {
                lstVirtualAnimal.Items.Add("You've chosen the Block C - omnivore location, Please select omnivores!");//displayed when Third option is selected
            }
        }

        //Method - generates Animal Sound 
        public void GeneratesAnimalSound()
        {
            string food = txtFood.Text;//local variable for textbox Food
            string foodQuantity = txtFoodQuantity.Text;//local variable for 

            if (int.TryParse(foodQuantity, out int int_foodQuantity))
            {
                animalDict = new Dictionary<string, Animal>
            {
                // Add animal types
                 {"Lion", new Lion(food,int_foodQuantity)},//added Lion
                 {"Hyena", new Hyena(food,int_foodQuantity)},//added Hyena
                 {"Zebra", new Zebra(food,int_foodQuantity)},//added Zebra
                 {"Elephant", new Elephant(food,int_foodQuantity)},//added Elephant
                 {"Warthog", new Warthog(food,int_foodQuantity)},//added Warthog
                 {"Apes", new Apes(food,int_foodQuantity)},//added Apes

            };

                try
                {
                    if (cmbAnimal.SelectedItem == null)
                    {
                        MessageBox.Show("Animal Combo box is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw new NullReferenceException("Please select an option from the Animal Combo box.");
                    }
                    else if (animalDict.TryGetValue(cmbAnimal.SelectedItem.ToString(), out Animal soundAnimal))
                    {
                        string result = soundAnimal.Speak();
                        lstVirtualAnimal.Items.Add(result);
                    }
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        //method - Simimulates Eating of Animal
        public void AnimalEating()
        {
            string txtfood = txtFood.Text;
            string txtfoodQuantity = txtFoodQuantity.Text;

            if (int.TryParse(txtfoodQuantity, out int int_foodQuantity))
            {
                // Create the animal dictionary
                Dictionary<string, Animal> animalDict = new Dictionary<string, Animal>
        {
            {"Lion", new Lion(txtfood, int_foodQuantity)},
            {"Hyena", new Hyena(txtfood,int_foodQuantity)},
            {"Zebra", new Zebra(txtfood,int_foodQuantity)},
            {"Elephant", new Elephant(txtfood,int_foodQuantity)},
            {"Warthog", new Warthog(txtfood,int_foodQuantity)},
            {"Apes", new Apes(txtfood,int_foodQuantity)}
        };

                try
                {
                    string animal = cmbAnimal.SelectedItem?.ToString(); // Safely get the selected animal

                    if (animalDict.TryGetValue(animal, out Animal selectedAnimal))
                    {
                        if (txtFoodQuantity.Text == null) // Check if quantity is empty
                        {
                            Console.WriteLine($"Quantity can't be empty");
                            MessageBox.Show("Quantity Text Box is Empty!", "Empty Text Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            selectedAnimal.Eat(txtfood, int_foodQuantity);
                            lstVirtualAnimal.Items.Add($"The {animal} ate {int_foodQuantity} {txtfood}.");
                        }
                    }
                    else
                    {
                        lstVirtualAnimal.Items.Add("Invalid animal selection.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        //method - Simulates the movement of an animal
        public void AnimalMovement()
        {
            string food = txtFood.Text;//local variable for textbox Food
            string foodQuantity = txtFoodQuantity.Text;//local variable for food quantity

            if (int.TryParse(foodQuantity, out int int_foodQuantity))
            {
                animalDict = new Dictionary<string, Animal>
            {
                // Add animal types
                 {"Lion", new Lion(food,int_foodQuantity)},//added Lion
                 {"Hyena", new Hyena(food,int_foodQuantity)},//added Hyena
                 {"Zebra", new Zebra(food,int_foodQuantity)},//added Zebra
                 {"Elephant", new Elephant(food,int_foodQuantity)},//added Elephant
                 {"Warthog", new Warthog(food,int_foodQuantity)},//added Warthog
                 {"Apes", new Apes(food,int_foodQuantity)},//added Apes

            };

                string animal = cmbAnimal.SelectedItem.ToString();//creating variable for animal
                                                                  //conditional statement for
                if (animalDict.TryGetValue(animal, out Animal moveableAnimal) && moveableAnimal is IClimbing climbingAnimal)
                {
                    moveAnimal(moveableAnimal);
                    //Displays message to listbox stating that selected animal is climbing something
                    string climbingRes = climbingAnimal.Climb();
                    lstVirtualAnimal.Items.Add(climbingRes);
                }
                else if (animalDict.TryGetValue(animal, out Animal animalObj) && animalObj is ISwimming swimmingAnimal)
                {
                    moveAnimal(animalObj);
                    //Displays message to listbox stating that selected animal is swimming
                    string SwimmingRes = swimmingAnimal.Swim();
                    lstVirtualAnimal.Items.Add(SwimmingRes);
                }
                else if (animalDict.TryGetValue(animal, out Animal animalObj2) && animalObj2 is IOtherActions otheractions)
                {
                    moveAnimal(animalObj2);
                    //displaying other actions animals are doing besides climbing and swimming
                    string OtherActionRes = otheractions.OtherAction();
                    lstVirtualAnimal.Items.Add(OtherActionRes);
                }
            }
        }

        //method - simulates the feeding process of an animal
        public void AnimalFeeding()
        {
            string food = txtFood.Text;//local variable for textbox Food
            string foodQuantity = txtFoodQuantity.Text;//local variable for 

            if (int.TryParse(foodQuantity, out int int_foodQuantity))
            {
                animalDict = new Dictionary<string, Animal>
                {
                    // Add animal types
                     {"Lion", new Lion(food,int_foodQuantity)},//added Lion
                     {"Hyena", new Hyena(food,int_foodQuantity)},//added Hyena
                     {"Zebra", new Zebra(food,int_foodQuantity)},//added Zebra
                     {"Elephant", new Elephant(food,int_foodQuantity)},//added Elephant
                     {"Warthog", new Warthog(food,int_foodQuantity)},//added Warthog
                     {"Apes", new Apes(food,int_foodQuantity)},//added Apes

                };

                try
                {
                    if (cmbAnimal.SelectedIndex == -1)
                    {
                        MessageBox.Show("Animal Combo box is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw new NullReferenceException("Please select an option from the Animal Combo box.");
                    }
                    else if (animalDict.TryGetValue(cmbAnimal.SelectedItem.ToString(), out Animal feedableAnimal))
                    {
                        //feed the selected animal
                        string result = feedableAnimal.Feed();//creating instance of Interface method Move
                        lstVirtualAnimal.Items.Add(result);
                    }
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                try{
                    IsQuantityEmpty_NotNum();//calls method [Checks if textbox quantity is empty or NaN]
                    IsFoodNum_Empty();//calls method [Checks if textbox food is empty or NaN]
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }

        }

        //method - check if Quantity text box is empty or number
        public void IsQuantityEmpty_NotNum()
        {
            //condition to check if quntity text box is empty OR number
            if (string.IsNullOrEmpty(txtFoodQuantity.Text))
            {
                MessageBox.Show("Quantity Text Box is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new NullReferenceException("Quantity TextBox can't be empty!");
            }

            try 
            {
                int Quantity_num = int.Parse(txtFoodQuantity.Text);
                if (!int.TryParse(txtFoodQuantity.Text, out int _ ))
                {
                    MessageBox.Show("Entered Quantity Not a Number!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new FormatException("Entered quantity is not a number!");
                }
            } 
            catch (FormatException ex) 
            {
                Console.WriteLine(ex.Message);  
            }
        }

        #region "Checks if Food text box is number or is Empty"
        public void IsFoodNum_Empty()
        {
            if (string.IsNullOrEmpty(txtFood.Text))
            {
                MessageBox.Show("Food Text Box is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new NullReferenceException("Food TextBox can't be empty!");
            }
            else
            {
                // Try parsing the input as a double
                if (double.TryParse(txtFood.Text, out double foodValue))
                {
                    Console.WriteLine($"Entered value is a valid number: {foodValue}");
                }
                else
                {
                    Console.WriteLine("Entered value is not String value!");
                    MessageBox.Show("Entered value is not a String value!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } 
        #endregion


        //error handelling when user selects wrong Animal type , Species and Location for button move  
        public void IsCorrectSelection_btnMove()
        {
            try
            {
                int animalTypeIndex = cmbAnimal.SelectedIndex;
                int speciesIndex = cmbSpecies.SelectedIndex;
                int locationIndex = cmbLocation.SelectedIndex;

                if (animalTypeIndex == 0 && speciesIndex == 0 && locationIndex == 0 || animalTypeIndex == 1 && speciesIndex == 0 && locationIndex == 0
                    || animalTypeIndex == 2 && speciesIndex == 1 && locationIndex == 1 || animalTypeIndex == 3 && speciesIndex == 1 && locationIndex == 1
                    || animalTypeIndex == 4 && speciesIndex == 2 && locationIndex == 2 || animalTypeIndex == 5 && speciesIndex == 2 && locationIndex == 2)
                {
                    if (btnMove.Enabled)
                    {
                        AnimalMovement();
                    }
                    else
                    {
                       Console.WriteLine("Button not selected");
                    }
                }
                else
                {
                    lstVirtualAnimal.Items.Clear();
                    Console.WriteLine("Please select valid options for animal type, species, and location.");
                    MessageBox.Show("Please choose appropiate matches", "Invalid Selections", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Selected wrong arrangement of combo boxes!" + ex.Message);
            }

        }

        //error handelling when user selects wrong Animal type , Species and Location for button feed  
        public void IsCorrectSelection_btnFeed()
        {
            try
            {
                int animalTypeIndex = cmbAnimal.SelectedIndex;
                int speciesIndex = cmbSpecies.SelectedIndex;
                int locationIndex = cmbLocation.SelectedIndex;

                if (animalTypeIndex == 0 && speciesIndex == 0 && locationIndex == 0 || animalTypeIndex == 1 && speciesIndex == 0 && locationIndex == 0
                    || animalTypeIndex == 2 && speciesIndex == 1 && locationIndex == 1 || animalTypeIndex == 3 && speciesIndex == 1 && locationIndex == 1
                    || animalTypeIndex == 4 && speciesIndex == 2 && locationIndex == 2 || animalTypeIndex == 5 && speciesIndex == 2 && locationIndex == 2)
                {
                    if (btnFedAnimal.Enabled)
                    {
                        AnimalFeeding();
                    }
                    else
                    {
                        Console.WriteLine("Button not selected");
                    }
                }
                else
                {
                    lstVirtualAnimal.Items.Clear();
                    Console.WriteLine("Please select valid options for animal type, species, and location.");
                    MessageBox.Show("Please choose appropiate matches", "Invalid Selections", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Selected wrong arrangement of combo boxes!" + ex.Message);
            }

        }

        //error handelling when user selects wrong Animal type , Species and Location for button sound  
        public void IsCorrectSelection_btnSound()
        {
            try
            {
                int animalTypeIndex = cmbAnimal.SelectedIndex;
                int speciesIndex = cmbSpecies.SelectedIndex;
                int locationIndex = cmbLocation.SelectedIndex;

                if (animalTypeIndex == 0 && speciesIndex == 0 && locationIndex == 0 || animalTypeIndex == 1 && speciesIndex == 0 && locationIndex == 0
                    || animalTypeIndex == 2 && speciesIndex == 1 && locationIndex == 1 || animalTypeIndex == 3 && speciesIndex == 1 && locationIndex == 1
                    || animalTypeIndex == 4 && speciesIndex == 2 && locationIndex == 2 || animalTypeIndex == 5 && speciesIndex == 2 && locationIndex == 2)
                {
                    if (btnSound.Enabled)
                    {
                        GeneratesAnimalSound();
                    }
                    else
                    {
                        Console.WriteLine("Button not selected");
                    }
                }
                else
                {
                    lstVirtualAnimal.Items.Clear();
                    Console.WriteLine("Please select valid options for animal type, species, and location.");
                    MessageBox.Show("Please choose appropiate matches", "Invalid Selections", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Selected wrong arrangement of combo boxes!" + ex.Message);
            }

        }

        //error handelling when user selects wrong Animal type , Species and Location for button sound  
        public void IsCorrectSelection_btnEat()
        {
            try
            {
                int animalTypeIndex = cmbAnimal.SelectedIndex;
                int speciesIndex = cmbSpecies.SelectedIndex;
                int locationIndex = cmbLocation.SelectedIndex;

                if (animalTypeIndex == 0 && speciesIndex == 0 && locationIndex == 0 || animalTypeIndex == 1 && speciesIndex == 0 && locationIndex == 0
                    || animalTypeIndex == 2 && speciesIndex == 1 && locationIndex == 1 || animalTypeIndex == 3 && speciesIndex == 1 && locationIndex == 1
                    || animalTypeIndex == 4 && speciesIndex == 2 && locationIndex == 2 || animalTypeIndex == 5 && speciesIndex == 2 && locationIndex == 2)
                {
                    if (btnEat.Enabled)
                    {
                        AnimalEating();
                    }
                    else
                    {
                        Console.WriteLine("Button not selected");
                    }
                }
                else
                {
                    lstVirtualAnimal.Items.Clear();
                    Console.WriteLine("Please select valid options for animal type, species, and location.");
                    MessageBox.Show("Please choose appropiate matches", "Invalid Selections", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Selected wrong arrangement of combo boxes!" + ex.Message);
            }

        }

    }

}

