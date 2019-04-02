/*
Enter your query here.
*/
SELECT DISTINCT CITY FROM STATION WHERE CITY NOT RLIKE '^[aeiouAEIOU].*[aeiouAEIOU]$'
