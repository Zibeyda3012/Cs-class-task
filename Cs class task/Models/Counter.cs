using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_class_task.Models
{
    internal class Counter
    {
        public int min { get; set; }
        public int max { get; set; }

        private int _currentValue;

        public int current_value
        {
            get { return _currentValue; }
            set { _currentValue = value; }
        }


        public Counter()
        {
            this.min = 0;
            this.max = 100;
            this.current_value = min;

        }

        public Counter(int min, int max)
        {
            this.min = min;
            this.max = max;
            this.current_value = min;
        }

        public void Increment()
        {
            if (this.current_value < this.max)
                this.current_value++;
            else
                this.current_value = min;
        }

        public void Decrement()
        {
            if (this.current_value > this.min)
                this.current_value -= 1;
            else
                this.current_value = min;
        }

        public int GetCurrent() { return this.current_value; }


    }
}
