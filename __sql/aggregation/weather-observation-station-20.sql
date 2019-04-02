SET @rowindex := -1;
 
SELECT
   ROUND(AVG(lat.LAT_N),4)
FROM
   (SELECT @rowindex:=@rowindex + 1 AS rowindex,
           station.LAT_N AS LAT_N
    FROM station
    ORDER BY LAT_N) AS lat
WHERE
lat.rowindex IN (FLOOR(@rowindex / 2) , CEIL(@rowindex / 2));
