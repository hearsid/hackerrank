import java.time.*;
class Result {

    /*
     * Complete the 'findDay' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER month
     *  2. INTEGER day
     *  3. INTEGER year
     */
    
    public static String getDay(int day, int month, int year) {
        return java.time.format.DateTimeFormatter.ofPattern("EEEE")
            .format(LocalDate.of(year, month, day));
    }

    public static String findDay(int month, int day, int year) {
        return getDay(day, month, year).toUpperCase();
    }

}
