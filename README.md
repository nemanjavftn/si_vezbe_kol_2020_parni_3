# si_vezbe_kol_2020_parni_3

Група: I
Тип апликације: трослојна архитектура, Windows
-	Креирати базу података под називом LibraryDB и у оквиру ње направити табелу Books са следећим колонама: Id int PK auto increment, Name nvarchar(50) NOT NULL, NumberOfPages int NULL. (2 бода)
-	Креирати слој који ће вршити конекцију на базу података (Data Layer) и где ће постојати један репозиторијум за комуникацију са креираном табелом у бази података (Books). У оквиру репозиторијума треба да постоје методе: InsertBook (користи се за унос података у табелу Books) и GetAllBooks (за довлачење свих књига из базе података). (5 бодова)
-	Креирати слој у ком ће се налазити логика апликације и где ће у оквиру посебне business класе за рад са Book вертикалом постојати две методе које преко Data слоја врше унос и довлачење књига из репозиторијума. Метода која врши довлачење података треба да врати само књиге које имају преко 50 страница (NumberOfPages > 50). (5 бодова)
-	На крају, направити .Net Windows Forms апликацију где ће се на почетној форми (текст форме на насловној линији: Biblioteka) вршити унос једне књиге у базу података а у доњем делу форме ће се налазити један ListBox који приказује листу свих књига (“Id. Name”). На сваки унос нове књиге треба refresh-овати листу. (6 бодова)
Напомене: Користити лабеле поред контрола како би форма “имала смисла”. У моделима користити приватна поља и јавна својства (или аутосвојства).
