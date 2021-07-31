using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class CounterState
    {
        int _count = 0;

        public Action OnStateChanged;

        public int Count 
        {
            get 
            {
                return this._count;
            }
            set 
            {
                this._count = value;
                this.Refresh();
            }
        }

        void Refresh()
        {
            this.OnStateChanged?.Invoke();
        }
    }
}
