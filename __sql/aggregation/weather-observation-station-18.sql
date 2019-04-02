/** get min values and assign them by AS 
*
*/
select round(max(LAT_N)-min(LAT_N)+ max(LONG_W) - min(LONG_W), 4) from station
