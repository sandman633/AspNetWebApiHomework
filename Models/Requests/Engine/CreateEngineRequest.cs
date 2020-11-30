using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Requests.Car
{
    public class CreateEngineRequest
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Power { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }
    }
}
