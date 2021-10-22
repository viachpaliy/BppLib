function MachineConfiguration(axis0 = null, axis1 = null , axis2 = null){
                 class MachineConfigurationClass{
                    constructor(axis0, axis1, axis2){}
                    isMachineCoordinate(value){return true;}
                    getVendor(){return vendor;}
                    getModel(){return "";}
                    getDescription(){return description;}
                 }
                return new MachineConfigurationClass(axis0, axis1, axis2);
                }
                
                machineConfiguration = MachineConfiguration();