class ZRangeClass{
    constructor(value = 0){this.range = value;}
    expandToRange(zRange){ 
        if (zRange > this.range) this.range = zRange;
         }
}

class SectionClass{
    constructor(tool, range){
        this.tool =tool;
        this.zRange = range;
    }
}

var sections = [];

function getNumberOfSections() {return sections.length;}

function getSection(i) {return sections[i];}