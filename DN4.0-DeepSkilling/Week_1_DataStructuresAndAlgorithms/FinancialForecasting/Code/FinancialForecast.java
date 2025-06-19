public class FinancialForecast {

    public static double futureValue(int year, double currentValue, double rate) {
        if (year == 0) return currentValue;  
        return futureValue(year - 1, currentValue, rate) * (1 + rate);
    }

    public static void main(String[] args) {
        double presentValue = 100000;   
        double growthRate = 0.1;     
        int years = 2;

        double result = futureValue(years, presentValue, growthRate);
        System.out.printf("Future value after %d years: %.2f\n", years, result);
    }
}
