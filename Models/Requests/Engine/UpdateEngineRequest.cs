using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Requests.Car
{
    public class UpdateEngineRequest : CreateEngineRequest
    {
        /// <summary>
        /// Идентификатор сущности.
        /// </summary>
        public long Id { get; set; }
    }
}
