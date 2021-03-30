using System.Collections.Generic;
using System.ComponentModel;

namespace WpfRectangleGrid.ViewModels
{
    public class Cell : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool isVisible;
        public bool IsVisible
        {
            get { return isVisible; }
            set
            {
                if (isVisible != value)
                {
                    isVisible = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(IsVisible)));
                }
            }
        }

        private bool isValid;
        public bool IsValid
        {
            get { return isValid; }
            set
            {
                if (isValid != value)
                {
                    isValid = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(IsValid)));
                }
            }
        }

        public Cell(bool visible)
        {
            IsVisible = visible;
            IsValid = true;
        }

    }

    public class ViewModel
    {
        public List<Cell> Cells { get; private set; }//  =  Enumerable.Range(0, 400).Select(i => new Cell()).ToList();

        public int Columns { get; set; }

        public ViewModel()
        {
            int min = 0, max = 0;
            Columns = 20;

            Cells = new List<Cell>();

            for (int row=0; row < 20; row++)
            {
                switch (row)
                {
                    case 0:
                    case 19:
                        min = 8;
                        max = 11;
                        break;
                    case 1:
                    case 18:
                        min = 6;
                        max = 13;
                        break;
                    case 2:
                    case 17:
                        min = 5;
                        max = 14;
                        break;
                    case 3:
                    case 16:
                        min = 4;
                        max = 15;
                        break;

                    case 4:
                    case 15:
                        min = 3;
                        max = 16;
                        break;

                    case 5:
                    case 14:
                    case 6:
                    case 13:
                        min = 2;
                        max = 17;
                        break;

                    case 7:
                    case 12:
                    case 8:
                    case 11:
                        min = 1;
                        max = 18;
                        break;

                    case 9:
                    case 10:
                        min = 0;
                        max = 19;
                        break;


                    default:
                        break;
                }

                for (int col=0; col < 20; col++)
                {
                    Cells.Add(new Cell(col >= min && col <= max));
                }
            }

        }
    }
}
