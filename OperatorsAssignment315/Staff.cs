using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment315
{
    public class staff
    {
        public List<Employee> employee { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play();

        public virtual void ListPlayer()
        {
            foreach (staff staff in Staff)
            {
                Console.WriteLine(staff);
            }
        }
    }
}