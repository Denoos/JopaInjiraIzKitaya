using DnsFromPpk.Components;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DnsFromPpk
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public List<object> AllComponents { get; set; } = new();
        public List<object> AllSelectedComponents { get; set; } = new();
        public Cpu SelectedCpu { get; set; }
        public Gpu SelectedGpu { get; set; }
        public Ram SelectedRam { get; set; }
        public MotherBoard SelectedMotherBoard { get; set; }
        public ThermoPaste SelectedThermoPaste { get; set; }
        public ComputerCase SelectedComputerCase { get; set; }
        public Cooler SelectedCooler { get; set; }
        public PowerUnit SelectedPowerUnit { get; set; }
        public Ssd SelectedSsd { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            ComponentsAdding();
            DataContext = this;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AllSelectedComponents)));
        }

        private static MainWindow instance;

        public event PropertyChangedEventHandler? PropertyChanged;

        public static MainWindow GetInstance()
        { if (instance == null) { instance = new MainWindow(); } return instance; }

        public void ComponentsAdding()
        {
            //CPU
            AllComponents.Add(new Cpu { Name = "XEON", Cost = 100, Frequency = 3, Threads = 6});
            AllComponents.Add(new Cpu { Name = "Intel", Cost = 1000, Frequency = 4, Threads = 12});
            AllComponents.Add(new Cpu { Name = "Amd", Cost = 900, Frequency = 3, Threads = 8});

            //GPU
            AllComponents.Add(new Gpu { Name = "GTX 1050TI", Cost = 3000, Frequency = 300, VideoMemory = "12 ZB"});
            AllComponents.Add(new Gpu { Name = "GTX 1650TI", Cost = 13000, Frequency = 3, VideoMemory = "1 GB"});
            AllComponents.Add(new Gpu { Name = "RTX 6090TI-MAX-PLUS-PRO", Cost = 999999, Frequency = 3000000, VideoMemory = "1 B"});

            //RAM
            AllComponents.Add(new Ram { Name = "HyperX", Cost = 5000, Frequency = 5, Memory = "32 GB"});
            AllComponents.Add(new Ram { Name = "NVideo", Cost = 1000, Frequency = 3, Memory = "2 GB"});
            AllComponents.Add(new Ram { Name = "Huanan", Cost = 50, Frequency = 5000, Memory = "2048 TB"});

            //MotherBoard
            AllComponents.Add(new MotherBoard { Name = "Atermiter", Cost = 1300, PsiESlots = 1, RamSlots = 4});
            AllComponents.Add(new MotherBoard { Name = "MSI Mad", Cost = 10000, PsiESlots = 1, RamSlots = 4});
            AllComponents.Add(new MotherBoard { Name = "ASRock", Cost = 5500, PsiESlots = 1, RamSlots = 2});

            //ThermoPaste
            AllComponents.Add(new ThermoPaste { Name = "КПТ-8", Cost = 100, Popularity = "Very Popular", Quality = "Grandfather couldn't wash it off even with moonshine" });
            AllComponents.Add(new ThermoPaste { Name = "MX-11", Cost = 110000, Popularity = "Only 1 copy", Quality = "Timurka approves it" });
            AllComponents.Add(new ThermoPaste { Name = "MX-4", Cost = 1000, Popularity = "So Popular", Quality = "Good" });

            //SSD
            AllComponents.Add(new Ssd { Name = "Kingston", Cost = 1500, Memory = "120 GB", Speed = 1200});
            AllComponents.Add(new Ssd { Name = "Patriot", Cost = 5000, Memory = "520 GB", Speed = 1400});
            AllComponents.Add(new Ssd { Name = "ADATA", Cost = 15000, Memory = "1 TB", Speed = 4000});

            //PowerUnit
            AllComponents.Add(new PowerUnit { Name = "KSAS", Cost = 1000, Power = 20000, Sertificat = "The Word of God" });
            AllComponents.Add(new PowerUnit { Name = "Thermaltake", Cost = 3000, Power = 600, Sertificat = "80 PLUS Gold" });
            AllComponents.Add(new PowerUnit { Name = "BeQuet", Cost = 7000, Power = 1000, Sertificat = "80 PLUS Platinum" });

            //ComputerCase
            AllComponents.Add(new ComputerCase { Name = "Prime Box", Cost = 2500, MaxGpuLong = 450, SsdSlots = 2});
            AllComponents.Add(new ComputerCase { Name = "Ginzzu", Cost = 3500, MaxGpuLong = 250, SsdSlots = 4});
            AllComponents.Add(new ComputerCase { Name = "Box From Fridge", Cost = 50, MaxGpuLong = 1750, SsdSlots = 100});

            //Cooler
            AllComponents.Add(new Cooler { Name = "BOX Cooler", Cost = 150, Noise = 100, Power = 60});
            AllComponents.Add(new Cooler { Name = "ID-Cooling", Cost = 750, Noise = 23, Power = 95});
            AllComponents.Add(new Cooler { Name = "GameMax Sigma", Cost = 3999, Noise = 26, Power = 200});
        }

        private void SelectCPU(object sender, RoutedEventArgs e)
        {
            SelectCPU af = new();
            af.Show();
        }

        private void SelectGPU(object sender, RoutedEventArgs e)
        {
            SelectGPU af = new();
            af.Show();
        }

        private void SelectComputerCase(object sender, RoutedEventArgs e)
        {
            SelectComputerCase af = new();
            af.Show();
        }

        private void SelectCooler(object sender, RoutedEventArgs e)
        {
            SelectCooler af = new();
            af.Show();
        }

        private void SelectMotherBoard(object sender, RoutedEventArgs e)
        {
            SelectMotherBoard af = new();
            af.Show();
        }

        private void SelectPowerUnit(object sender, RoutedEventArgs e)
        {
            SelectPowerUnit af = new();
            af.Show();
        }

        private void SelectRAM(object sender, RoutedEventArgs e)
        {
            SelectRAM af = new();
            af.Show();
        }

        private void SelectSSD(object sender, RoutedEventArgs e)
        {
            SelectSSD af = new();
            af.Show();
        }

        private void SelectThermoPaste(object sender, RoutedEventArgs e)
        {
            SelectThermoPaste af = new();
            af.Show();
        }
    }
}