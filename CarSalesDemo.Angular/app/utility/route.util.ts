export class RouteUtil {
    public static ERROR_ID = -999999999999999; 
    public static getValidateType(values: any): string {
        console.log("_validateType " + values['type']);
        return ((values['type'] === "0") || (values['type'] === "1")) ? (values['type']) : '';
    }
    public static validId(values: any): number {
        console.log("_validate id " + values['id']);
        return (+values['id']) > 0 ? +values['id'] : RouteUtil.ERROR_ID;
    }
}