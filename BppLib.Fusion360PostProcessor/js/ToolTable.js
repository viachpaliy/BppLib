class ToolTableClass{
    constructor(){this.tools = [];}
    getNumberOfTools() {return this.tools.length;}
    addTool(tool) {this.tools.push(tool);}
    getTool(number) {return this.tools[number];}
}

var toolTable = new ToolTableClass();

class ToolClass{
    constructor(number = 0, diameter = 12, cornerRadius = 0, taperAngle = 0, toolType = "End Mill", bodyLength = 0, holderLength = 0){
        this.number = number;
        this.diameter = diameter;
        this.cornerRadius = cornerRadius;
        this.taperAngle = taperAngle;
        this.type = toolType;
        this.bodyLength = bodyLength;
        this.holderLength = holderLength;
    }
}

function addTool(number = 0, diameter = 12, cornerRadius = 0, taperAngle = 0, toolType = "End Mill", bodyLength = 0, holderLength = 0){
    toolTable.addTool(new ToolClass(number, diameter, cornerRadius, taperAngle, toolType, bodyLength , holderLength ));
} 
function getToolTable(){return toolTable;}
function getToolTypeName(toolType){return toolType;}

