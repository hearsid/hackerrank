SELECT IF(gd.Grade >= 8, st.Name,
          NULL), gd.Grade,
          st.Marks
FROM Students AS st
JOIN Grades AS gd
ON st.Marks BETWEEN gd.Min_Mark AND gd.Max_Mark
ORDER BY gd.Grade DESC, st.name, st.Marks

