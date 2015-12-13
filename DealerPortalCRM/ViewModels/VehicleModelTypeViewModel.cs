using System;
using System.Collections.Generic;
using Portal.Core.Models.ScoringEngine;


namespace DealerPortalCRM.ViewModels
{
    public class VehicleModelTypeViewModel
    {
        // VehicleMakeType list
        public List<VehicleMakeType> LiVehicleMakeType { get; set; }

        // VehicleMakeType properties
        public int VehicleMakeTypeId { get; set; }
        public String VehicleMakeTypeType { get; set; }
        public String VehicleMakeTypeDisplayName { get; set; }

        //-------------------------------------------------

        // VehicleMakeModelClass properties
        public int VehiclModelTypeId { get; set; }
        public string VehicleModelTypeName { get; set; }
        public int VehicleModelTypeCreatedById { get; set; }
        public int VehicleModelTypeModifiedById { get; set; }
        public DateTime VehicleModelTypeCreatedDate { get; set; }
        public DateTime VehicleModelTypeModifiedDate { get; set; }   
    }
}

