
select * from Lancamentos
--select * from Anos
where tipo = 'entradas' 
order by id_lancamento

update Anos set ano = '2022' where Id_Ano = 42

SELECT * from lancamentos WHERE tipo = 'saidas' order by id_lancamento

SELECT * from lancamentos WHERE tipo = 'Entradas' order by id_lancamento

Select lan.Id_Lancamento, lan.Tipo, lan.Descricao,
		lan.Valor, lan.Mes, a.Ano, lan.Id_Ano, lan.Data
From Lancamentos lan 
INNER JOIN Anos a 
On a.Id_Ano = lan.Id_Ano where a.Ano = DATENAME(year, GetDate()) and lan.mes = DATENAME(MONTH, GetDate())

Select * From Lancamentos lan INNER JOIN Anos a On a.Id_Ano = lan.Id_Ano where ano = 2023

SELECT * from Lancamentos Where Data = DATENAME(year, GetDate())

SELECT DATENAME(weekday, GetDate()) + ', '   +
       DATENAME(day, GetDate())     + ' de ' +
       DATENAME(month, GetDate())   + ' de ' +
       DATENAME(year, GetDate())


Select case month(getdate()) when  1 then 'Janeiro'
        when  2 then 'Fevereiro'
        when  3 then 'Março'
        when  4 then 'Abril'
        when  5 then 'Maio'
        when  6 then 'Junho'
        when  7 then 'Julho'
        when  8 then 'Agosto'
        when  9 then 'Setembro'
        when 10 then 'Outubro'
        when 11 then 'Novembro'
        when 12 then 'Dezembro'
    end + ' - ' + cast(year(getdate()) as varchar(4))
 As MesAno

 SELECT DATENAME(month, GetDate())   + ' de ' +  DATENAME(year, GetDate())

 -------------------------------------------------------------

 SELECT
   Data,
   Mes,
   YEAR( Tempo ) - 1 AS Anos,
   MONTH( Tempo ) - 1 AS Meses,
   DAY( Tempo ) - 1 AS FCCDias

FROM (
  SELECT
     Data,
     CAST( GetDate() AS date ) AS Mes,
     DATEADD( day, -DAY( Data ) + 1,
        DATEADD( month, -MONTH( Data ) + 1,
           DATEADD( year, -YEAR( Data ) + 1,
              CAST( GetDate() AS date )
           )
        )
     ) AS Tempo FROM Lancamentos
  ) AS T;

  -- TRAS ANO E MES TOTAL
  SELECT Tipo
      ,CAST(YEAR(Data) AS CHAR(4))
      +RIGHT('0' + CAST(MONTH(Data) AS VARCHAR(2)), 2) AS Mes
      ,SUM(Valor)                                       AS Valor
FROM Lancamentos
WHERE Data >= DATEADD(MONTH, -12, GETDATE()) 
GROUP BY Tipo
		--,Data
        ,CAST(YEAR(Data) AS CHAR(4)) 
         +RIGHT('0' + CAST(MONTH(Data) AS VARCHAR(2)), 2)

	------	 ---ANO E MES MAIS PERFORMATICO.  ----- -------
		select lan.Tipo,
		a.Ano,
		(substring(convert(varchar(10), lan.Data,103), 4, 10)) Data, 
		sum(lan.Valor) Valor_Total_Por_Mes
		from Lancamentos lan 
			INNER JOIN Anos a 
			On lan.Id_Ano = a.Id_Ano		
		where Data >= DATEADD(MONTH, -2, GETDATE())
		group by lan.Tipo, (substring(convert(varchar(10), lan.Data,103), 4, 10)), a.Ano
		order by a.Ano	

		---//----

		SELECT        lan.Tipo, lan.Mes, SUBSTRING(CONVERT(varchar(10), lan.Data, 103), 4, 10) AS Data, sum(lan.Valor)
		FROM            Lancamentos AS lan INNER JOIN
                         Anos AS a ON a.Id_Ano = lan.Id_Ano
		WHERE        (lan.Mes = 'março')
		GROUP BY lan.Tipo, Data, lan.Valor, lan.Mes
		ORDER BY lan.Mes
		
		--------------- TRAS Dia a Dia.
		select Tipo,
				Descricao,
				Valor,
				(substring(convert(varchar(10), Data,103), 1, 10)) Data
		 from  Lancamentos
		 where Data >= DATEADD(MONTH, -12, GETDATE()) 
		 group by Tipo,
				  Descricao,
				  Valor,
				  Data
				order by Data

	--------------       ////////////////////	-------------------------------------------------
		SELECT     Tipo, Valor, Data
		FROM          Lancamentos
		WHERE         Tipo = 'Entradas'
					  and Data <= DATEADD(MONTH, 11, convert(varchar(10), getdate(), 103))
			group by Tipo,
				  Data,
				  Valor

		GROUP BY lan.Tipo, SUBSTRING(CONVERT(varchar(10), lan.Data, 103), 4, 10), a.Ano
		ORDER BY a.Ano

		 
		 

		 SELECT DATENAME(weekday, GetDate()) + ', '   +
       DATENAME(day, GetDate())     + ' de ' +
       DATENAME(month, GetDate())   + ' de ' +
       DATENAME(year, GetDate())

	   

SELECT        MONTH(lan.Data) AS Meses, SUM(lan.Valor) AS Soma_dos_Dias_Por_Mes, lan.Tipo
FROM            Lancamentos AS lan INNER JOIN
                Anos AS a ON a.Id_Ano = lan.Id_Ano
WHERE        Tipo = 'Entradas'
and (lan.Mes = @Mes) AND (a.Ano = DATENAME(year, GETDATE()))
GROUP BY MONTH(Data), Tipo

		

