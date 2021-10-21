function createModalGroup(obj, arr, form){
                class createModalGroupClass{
                    constructor(obj, arr, form){
                        this.obj = obj;
                        this.arr = arr;
                        this.form = form;
                    }
                    format(value){
                        return this.form.format(value);
                    }
                }
                return new createModalGroupClass(obj, arr, form);
            }