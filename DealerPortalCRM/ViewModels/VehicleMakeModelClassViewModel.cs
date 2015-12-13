using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Portal.Core.Models.ScoringEngine;

namespace DealerPortalCRM.ViewModels
{
    public class VehicleMakeModelClassViewModel
    {
        // VehicleMakeType list
        public List<VehicleMakeType> LiVehicleMakeType { get; set; }

        // VehicleMakeType properties
        [Required(ErrorMessage = "Vehicle make is required.")]
        public int VehicleMakeTypeId { get; set; }
        public String VehicleMakeTypeType { get; set; }
        public String VehicleMakeTypeDisplayName { get; set; }

        //------------------------------------------------

        // VehicleModelType list
        public List<VehicleModelType> LiVehicleModelType { get; set; }

        // VehicleModelType properties
        [Required(ErrorMessage = "Vehicle model is required.")]
        public int VehicleModelTypeId { get; set; }
        public String VehicleModelTypeType { get; set; }
        public String VehicleModelTypeDisplayName { get; set; }

        //------------------------------------------------

        // VehicleClassType list
        public List<VehicleClassType> LiVehicleClassType { get; set; }

        // VehicleClassType properties
        [Required(ErrorMessage = "Vehicle class is required.")]
        public int VehicleClassTypeId { get; set; }
        public String VehicleClassTypeType { get; set; }
        public String VehicleClassTypeDisplayName { get; set; }

        //-------------------------------------------------

        // VehicleMakeModelClass properties
        public int VehicleMakeModelClassId { get; set; }
        public int VehicleMakeModelClassCreatedById { get; set; }
        public int VehicleMakeModelClassModifiedById { get; set; }
        public DateTime VehicleMakeModelClassCreatedDate { get; set; }
        public DateTime VehicleMakeModelClassModifiedDate { get; set; }
    }
}

