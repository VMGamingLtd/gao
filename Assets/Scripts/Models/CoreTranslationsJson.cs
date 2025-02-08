namespace Assets.Scripts.Models
{
    public class CoreTranslationsJson
    {
        public static string json = @"
{
    ""header"": ""Core Translations"",
    ""words"": [
      { 
        ""identifier"": ""Yes"",
        ""english"": ""Yes"",
        ""russian"": ""Да"",
        ""chinese"": ""是"",
        ""slovak"": ""Áno""
      },
      {
        ""identifier"": ""No"",
        ""english"": ""No"",
        ""russian"": ""Нет"",
        ""chinese"": ""没有"",
        ""slovak"": ""Nie""
      },
      {
        ""identifier"": ""Add"",
        ""english"": ""Add"",
        ""russian"": ""Добавить"",
        ""chinese"": ""加"",
        ""slovak"": ""Pridať""
      },
      {
        ""identifier"": ""Revoke"",
        ""english"": ""Revoke"",
        ""russian"": ""Отозвать"",
        ""chinese"": ""撤回"",
        ""slovak"": ""Odvolanie""
      },
      {
        ""identifier"": ""Accept"",
        ""english"": ""Accept"",
        ""russian"": ""Принять"",
        ""chinese"": ""接受"",
        ""slovak"": ""Prijať""
      },
      {
        ""identifier"": ""Reject"",
        ""english"": ""Reject"",
        ""russian"": ""Отклонить"",
        ""chinese"": ""拒绝"",
        ""slovak"": ""Odmietnuť""
      },
      {
        ""identifier"": ""ERROR"",
        ""english"": ""ERROR"",
        ""russian"": ""Ошибка"",
        ""chinese"": ""错误"",
        ""slovak"": ""Chyba""
      },
      {
        ""identifier"": ""Equipment"",
        ""english"": ""Equipment"",
        ""russian"": ""Aппаратура"",
        ""chinese"": ""设备"",
        ""slovak"": ""Vybavenie""
      },
      {
        ""identifier"": ""FibrousLeaves"",
        ""english"": ""Fibrous leaves"",
        ""russian"": ""Волокнистые листья"",
        ""chinese"": ""纤维叶"",
        ""slovak"": ""Vláknité listy""
      },
      {
        ""identifier"": ""FibrousLeavesDesc"",
        ""english"": ""Basic resource needed to produce higher level items, such as bio fuel. <color=yellow>Food consumption</color>: 0.001/s."",
        ""russian"": ""Основной съедобный ресурс, необходимый для производства предметов более высокого уровня, таких как биотопливо. <color=yellow>Потребление еды</color>: 0,001/с."",
        ""chinese"": ""这是生产生物燃料等高级物品所需的基本且可食用的资源。<color=yellow>食物消耗</color>：0.001/s。"",
        ""slovak"": ""Základný zdroj surovín vužiteľný na výrobu predmetov vyššej úrovne, ako je biopalivo alebo na jedenie. <color=yellow>Spotreba potravy</color>: 0,001/s.""
      },
      {
        ""identifier"": ""Water"",
        ""english"": ""Water"",
        ""russian"": ""Вода"",
        ""chinese"": ""水"",
        ""slovak"": ""Voda""
      },
      {
        ""identifier"": ""WaterDesc"",
        ""english"": ""This water is not drinkable. Necessary for the production of distilled water."",
        ""russian"": ""Эта вода не пригодна для питья. Необходим для производства дистиллированной воды."",
        ""chinese"": ""这种水不能饮用。生产蒸馏水所必需的。"",
        ""slovak"": ""Táto voda nie je pitná. Nevyhnutná na výrobu destilovanej vody.""
      },
      {
        ""identifier"": ""Biofuel"",
        ""english"": ""Bio fuel"",
        ""russian"": ""Биотопливо"",
        ""chinese"": ""生物燃料"",
        ""slovak"": ""Biopalivo""
      },
      {
        ""identifier"": ""BiofuelDesc"",
        ""english"": ""A common fuel that is easy to produce but depletes quickly. Great for refueling small equipment."",
        ""russian"": ""Обычное топливо, которое легко производить, но быстро истощается. Отлично подходит для заправки небольшой техники."",
        ""chinese"": ""一种易于生产但消耗很快的普通燃料。非常适合为小型设备加油。"",
        ""slovak"": ""Bežné palivo, ktoré sa ľahko vyrába, no rýchlo sa vyčerpá. Skvelé na tankovanie malých zariadení.""
      },
      {
        ""identifier"": ""DistilledWater"",
        ""english"": ""Distilled water"",
        ""russian"": ""Дистиллированная вода"",
        ""chinese"": ""蒸馏水"",
        ""slovak"": ""Destilovaná voda""
      },
      {
        ""identifier"": ""DistilledWaterDesc"",
        ""english"": ""<color=yellow>Water consumption</color>: 0.001/s"",
        ""russian"": ""<color=yellow>Потребление воды</color>: 0.001/s"",
        ""chinese"": ""<color=yellow>用水量</color>: 0.001/s"",
        ""slovak"": ""<color=yellow>Spotreba vody</color>: 0.001/s""
      },
      {
        ""identifier"": ""BatteryCore"",
        ""english"": ""Battery core"",
        ""russian"": ""Ядро батареи"",
        ""chinese"": ""电池芯"",
        ""slovak"": ""Jadro batérie""
      },
      {
        ""identifier"": ""BatteryCoreDesc"",
        ""english"": ""Component necessary for creating energy products."",
        ""russian"": ""Компонент, необходимый для создания энергетических продуктов."",
        ""chinese"": ""该组件是创建能源产品所必需的。"",
        ""slovak"": ""Komponent potrebný na výrobu energetických produktov.""
      },
      {
        ""identifier"": ""Battery"",
        ""english"": ""Battery"",
        ""russian"": ""Батарея"",
        ""chinese"": ""电池"",
        ""slovak"": ""Batéria""
      },
      {
        ""identifier"": ""BatteryDesc"",
        ""english"": ""<color=yellow>Energy consumption</color>: 0.0166/s"",
        ""russian"": ""<color=yellow>Потребление энергии</color>: 0.0166/s"",
        ""chinese"": ""<color=yellow>能源消耗</color>: 0.0166/s"",
        ""slovak"": ""<color=yellow>Spotreba energie</color>: 0.0166/s""
      },
      {
        ""identifier"": ""OxygenTank"",
        ""english"": ""Oxygen tank"",
        ""russian"": ""Кислородный баллон"",
        ""chinese"": ""氧气罐"",
        ""slovak"": ""Kyslíková fľaša""
      },
      {
        ""identifier"": ""OxygenTankDesc"",
        ""english"": ""<color=yellow>Oxygen consumption</color>: 0.001/s"",
        ""russian"": ""<color=yellow>Потребление кислорода</color>: 0.001/s"",
        ""chinese"": ""<color=yellow>耗氧量</color>: 0.001/s"",
        ""slovak"": ""<color=yellow>Spotreba kyslíka</color>: 0.001/s""
      },
      {
        ""identifier"": ""LatexFoam"",
        ""english"": ""Latex foam"",
        ""russian"": ""Латексная пена"",
        ""chinese"": ""乳胶泡沫"",
        ""slovak"": ""Latexová pena""
      },
      {
        ""identifier"": ""LatexFoamDesc"",
        ""english"": ""A natural latex foam, derived from the sap of trees."",
        ""russian"": ""Натуральная латексная пена, полученная из сока деревьев."",
        ""chinese"": ""这是一种天然乳胶泡沫，源自树液。"",
        ""slovak"": ""Prírodná latexová pena získaná z miazgy stromov.""
      },
      {
        ""identifier"": ""ProteinBeans"",
        ""english"": ""Protein beans"",
        ""russian"": ""Протеиновые бобы"",
        ""chinese"": ""蛋白豆"",
        ""slovak"": ""Proteínové bobule""
      },
      {
        ""identifier"": ""ProteinBeansDesc"",
        ""english"": ""Edible resource that can be later processed."",
        ""russian"": ""Съедобный ресурс, который можно позже переработать."",
        ""chinese"": ""这是一种可以稍后加工的可食用资源。"",
        ""slovak"": ""Jedlý zdroj, ktorý možno neskôr spracovať.""
      },
      {
        ""identifier"": ""ProteinPowder"",
        ""english"": ""Protein powder"",
        ""russian"": ""Протеиновый порошок"",
        ""chinese"": ""蛋白粉"",
        ""slovak"": ""Proteínový prášok""
      },
      {
        ""identifier"": ""ProteinPowderDesc"",
        ""english"": ""Standard supplement that can be used in medicine or food."",
        ""russian"": ""Стандартная добавка, которую можно использовать в медицине или пище."",
        ""chinese"": ""这是一种常见的补充剂，可用于药物或食品。"",
        ""slovak"": ""Štandardný doplnok, ktorý možno použiť v medicíne alebo potravinách.""
      },
      {
        ""identifier"": ""BiomassLeaves"",
        ""english"": ""Biomass(leaves)"",
        ""russian"": ""Биомасса (листья)"",
        ""chinese"": ""生物量（树叶）"",
        ""slovak"": ""Biomasa(listy)""
      },
      {
        ""identifier"": ""BiomassLeavesDesc"",
        ""english"": ""Processed amount of biological material."",
        ""russian"": ""Переработанное количество биологического материала."",
        ""chinese"": ""这是经过加工的生物材料。"",
        ""slovak"": ""Spracované množstvo biologického materiálu.""
      },
      {
        ""identifier"": ""BiomassWood"",
        ""english"": ""Biomass(wood)"",
        ""russian"": ""Биомасса (древесина)"",
        ""chinese"": ""生物量（木材）"",
        ""slovak"": ""Biomasa(drevo)""
      },
      {
        ""identifier"": ""BiomassWoodDesc"",
        ""english"": ""Processed amount of biological material."",
        ""russian"": ""Переработанное количество биологического материала."",
        ""chinese"": ""这是经过加工的生物材料。"",
        ""slovak"": ""Spracované množstvo biologického materiálu.""
      },
      {
        ""identifier"": ""BioOil"",
        ""english"": ""Bio oil"",
        ""russian"": ""Биомасло"",
        ""chinese"": ""生物油"",
        ""slovak"": ""Bio olej""
      },
      {
        ""identifier"": ""BioOilDesc"",
        ""english"": ""Transparent, greasy substance made from natural resources."",
        ""russian"": ""Прозрачное, жирное вещество, изготовленное из природных ресурсов."",
        ""chinese"": ""这种油是一种由自然资源制成的透明油状物质。"",
        ""slovak"": ""Transparentná, olejovitá látka vyrobená z prírodných zdrojov.""
      },
      {
        ""identifier"": ""BuildingType"",
        ""english"": ""Building type:"",
        ""russian"": ""Тип здания:"",
        ""chinese"": ""建筑类型："",
        ""slovak"": ""Typ budovy:""
      },
      {
        ""identifier"": ""Consumption"",
        ""english"": ""Consumption:"",
        ""russian"": ""Потребление:"",
        ""chinese"": ""消耗："",
        ""slovak"": ""Spotreba:""
      },
      {
        ""identifier"": ""Output"",
        ""english"": ""Received quantity:"",
        ""russian"": ""Полученное количество:"",
        ""chinese"": ""收到数量："",
        ""slovak"": ""Prijaté množstvo:""
      },
      {
        ""identifier"": ""Materials"",
        ""english"": ""Materials:"",
        ""russian"": ""Материалы:"",
        ""chinese"": ""所需材料："",
        ""slovak"": ""Materiály:""
      },
      {
        ""identifier"": ""BiofuelGenerator"",
        ""english"": ""Bio fuel generator"",
        ""russian"": ""Генератор биотоплива"",
        ""chinese"": ""生物燃料发电机"",
        ""slovak"": ""Generátor biopalív""
      },
      {
        ""identifier"": ""BiofuelGeneratorDesc"",
        ""english"": ""Consumes  <color=yellow>Bio fuel </color>to generate electricity."",
        ""russian"": ""Потребляет <color=yellow>биотопливо </color> для выработки электроэнергии."",
        ""chinese"": ""消耗<color=yellow>生物燃料</color>来发电。"",
        ""slovak"": ""Na výrobu elektriny spotrebuje <color=yellow>biopalivo </color>.""
      },
      {
        ""identifier"": ""WaterPump"",
        ""english"": ""Water pump"",
        ""russian"": ""Bодяной насос"",
        ""chinese"": ""抽水机"",
        ""slovak"": ""Vodné čerpadlo""
      },
      {
        ""identifier"": ""WaterPumpDesc"",
        ""english"": ""Creates <color=yellow>10 Water</color> from the planet's reserves every 10 seconds."",
        ""russian"": ""Создает <color=yellow>10 единиц воды</color> из запасов планеты каждые 10 секунд."",
        ""chinese"": ""每 10 秒从地球储备中产生 <color=yellow>10 水</color>。"",
        ""slovak"": ""Ťaží <color=yellow>10 vody</color> zo zásob planéty každých 10 sekúnd.""
      },
      {
        ""identifier"": ""FibrousPlantField"",
        ""english"": ""Fibrous plant field"",
        ""russian"": ""Поле волокнистых растений"",
        ""chinese"": ""纤维植物领域"",
        ""slovak"": ""Pole vláknitých rastlín""
      },
      {
        ""identifier"": ""FibrousPlantFieldDesc"",
        ""english"": ""Allows you to harvest <color=yellow>fibrous leaves</color>."",
        ""russian"": ""Позволяет собирать <color=yellow>волокнистые листья</color>."",
        ""chinese"": ""这块田地可以让你收获<color=yellow>纤维状叶子</color>。"",
        ""slovak"": ""Umožňuje zber <color=yellow>Vláknitých listov</color>.""
      },
      {
        ""identifier"": ""Steam"",
        ""english"": ""Steam"",
        ""russian"": ""Пар"",
        ""chinese"": ""蒸汽"",
        ""slovak"": ""Para""
      },
      {
        ""identifier"": ""SteamDesc"",
        ""english"": ""Substance containing water in the gas phase created by the evaporation process."",
        ""russian"": ""Вещество, содержащее воду в газовой фазе, созданной в процессе испарения."",
        ""chinese"": ""这是一种通过蒸发过程产生的气相含水物质。"",
        ""slovak"": ""Látka obsahujúca vodu v plynnej fáze vytvorenej procesom odparovania.""
      },
      {
        ""identifier"": ""SteamGenerator"",
        ""english"": ""Steam generator"",
        ""russian"": ""Парогенератор"",
        ""chinese"": ""蒸汽发生器"",
        ""slovak"": ""Parný generátor""
      },
      {
        ""identifier"": ""SteamGeneratorDesc"",
        ""english"": ""Produces <color=yellow>energy</color> from steam."",
        ""russian"": ""Производит <color=yellow>энергию</color> из пара."",
        ""chinese"": ""该发电机从蒸汽产生<color=yellow>能量</color>。"",
        ""slovak"": ""Produkuje <color=yellow>energiu</color> z pary.""
      },
      {
        ""identifier"": ""Boiler"",
        ""english"": ""Boiler"",
        ""russian"": ""Котел"",
        ""chinese"": ""锅炉"",
        ""slovak"": ""Kotol""
      },
      {
        ""identifier"": ""BoilerDesc"",
        ""english"": ""Produces <color=yellow>steam</color> by heating water."",
        ""russian"": ""Нагревает воду для образования <color=yellow>пара</color>."",
        ""chinese"": ""该锅炉通过加热水产生<color=yellow>蒸汽</color>。"",
        ""slovak"": ""Vytvára <color=yellow>paru</color> ohrevom vody.""
      },
      {
        ""identifier"": ""ResearchDevice"",
        ""english"": ""Research device"",
        ""russian"": ""Исследовательское устройство"",
        ""chinese"": ""研究装置"",
        ""slovak"": ""Výskumné zariadenie""
      },
      {
        ""identifier"": ""ResearchDeviceDesc"",
        ""english"": ""Generates <color=yellow>research points</color> at the cost of electricity."",
        ""russian"": ""Устройство, генерирующее <color=yellow>точки исследования</color> с помощью электричества."",
        ""chinese"": ""这会利用电力产生<color=yellow>研究点</color>。"",
        ""slovak"": ""Generuje <color=yellow>výskumné body</color> za cenu elektriny.""
      },
      {
        ""identifier"": ""Wood"",
        ""english"": ""Wood"",
        ""russian"": ""Древесина"",
        ""chinese"": ""木头"",
        ""slovak"": ""Drevo""
      },
      {
        ""identifier"": ""WoodDesc"",
        ""english"": ""Basic construction material."",
        ""russian"": ""Основной строительный материал."",
        ""chinese"": ""这是建筑的基本材料。"",
        ""slovak"": ""Základný stavebný materiál.""
      },
      {
        ""identifier"": ""IronOre"",
        ""english"": ""Iron ore"",
        ""russian"": ""Железная руда"",
        ""chinese"": ""铁矿"",
        ""slovak"": ""Železná ruda""
      },
      {
        ""identifier"": ""IronOreDesc"",
        ""english"": ""Basic material for construction or smelting."",
        ""russian"": ""Основной ресурс для строительства или плавки."",
        ""chinese"": ""这是建筑或冶炼的基本资源。"",
        ""slovak"": ""Základný materiál pre stavbu alebo tavenie.""
      },
      {
        ""identifier"": ""Coal"",
        ""english"": ""Coal"",
        ""russian"": ""Уголь"",
        ""chinese"": ""煤炭"",
        ""slovak"": ""Uhlie""
      },
      {
        ""identifier"": ""CoalDesc"",
        ""english"": ""A vital source of energy mainly for industrial use."",
        ""russian"": ""Жизненно важный источник энергии, главным образом для промышленного использования."",
        ""chinese"": ""煤炭是重要的能源，主要用于工业用途。"",
        ""slovak"": ""Životne dôležitý zdroj energie, hlavne pre priemyselné využitie.""
      },
      {
        ""identifier"": ""IronBeam"",
        ""english"": ""Iron beam"",
        ""russian"": ""Железная балка"",
        ""chinese"": ""铁梁"",
        ""slovak"": ""Železný trám""
      },
      {
        ""identifier"": ""IronBeamDesc"",
        ""english"": ""Common component used to construct buildings frames."",
        ""russian"": ""Общий компонент, используемый для построения каркасов зданий."",
        ""chinese"": ""铁梁是用于建造建筑框架的标准构件。"",
        ""slovak"": ""Bežný komponent používaný na stavbu rámov budov.""
      },
      {
        ""identifier"": ""Electricity"",
        ""english"": ""Electricity"",
        ""russian"": ""Электричество"",
        ""chinese"": ""电力"",
        ""slovak"": ""Elektrina""
      },
      {
        ""identifier"": ""UVIndex"",
        ""english"": ""UV Index"",
        ""russian"": ""УФ-индекс"",
        ""chinese"": ""紫外线指数"",
        ""slovak"": ""UV index""
      },
      {
        ""identifier"": ""SunriseSunset"",
        ""english"": ""Sunrise / Sunset"",
        ""russian"": ""Восход / Закат"",
        ""chinese"": ""日出 / 日落"",
        ""slovak"": ""Východ / Západ""
      },
      {
        ""identifier"": ""Sunrise"",
        ""english"": ""Sunrise"",
        ""russian"": ""Восход"",
        ""chinese"": ""日出"",
        ""slovak"": ""Východ""
      },
      {
        ""identifier"": ""Sunset"",
        ""english"": ""Sunset"",
        ""russian"": ""Закат"",
        ""chinese"": ""日落"",
        ""slovak"": ""Západ""
      },
      {
        ""identifier"": ""Sunny"",
        ""english"": ""Sunny"",
        ""russian"": ""Солнечно"",
        ""chinese"": ""晴朗"",
        ""slovak"": ""Slnečno""
      },
      {
        ""identifier"": ""BuildingsStatistics"",
        ""english"": ""Buildings statistics"",
        ""russian"": ""Статистика построек"",
        ""chinese"": ""建筑物统计"",
        ""slovak"": ""Štatistika budov""
      },
      {
        ""identifier"": ""PlayerLevel"",
        ""english"": ""Player level"",
        ""russian"": ""Уровень игрока"",
        ""chinese"": ""球员等级"",
        ""slovak"": ""Úroveň hráča""
      },
      {
        ""identifier"": ""Survive"",
        ""english"": ""Survive"",
        ""russian"": ""Пережить"",
        ""chinese"": ""生存"",
        ""slovak"": ""Prežitie""
      },
      {
        ""identifier"": ""SignIn"",
        ""english"": ""Sign in"",
        ""russian"": ""Войти"",
        ""chinese"": ""登入"",
        ""slovak"": ""Prihlásiť sa""
      },
      {
        ""identifier"": ""Login"",
        ""english"": ""Log in"",
        ""russian"": ""Авторизоваться"",
        ""chinese"": ""登录"",
        ""slovak"": ""Prihlásiť sa""
      },
      {
        ""identifier"": ""NewUser"",
        ""english"": ""new user"",
        ""russian"": ""новый пользователь"",
        ""chinese"": ""新用戶"",
        ""slovak"": ""nový užívateľ""
      },
      {
        ""identifier"": ""RecoverPasswordUsername"",
        ""english"": ""Recover password / username"",  
        ""russian"": ""Восстановить пароль / имя пользователя"",
        ""chinese"": ""恢复密码 / 用户名"",
        ""slovak"": ""Obnoviť heslo / užívateľské meno""
      },
      {
        ""identifier"": ""NameEmail"",
        ""english"": ""Name / Email"",
        ""russian"": ""Имя / Электронная почта"",
        ""chinese"": ""姓名 / 電子郵件"",
        ""slovak"": ""Meno / Email""
      },
      {
        ""identifier"": ""CreateAccount"",
        ""english"": ""Create account"",
        ""russian"": ""Зарегистрироваться"",
        ""chinese"": ""创建账户"",
        ""slovak"": ""Vytvoriť účet""
      },
      {
        ""identifier"": ""Email"",
        ""english"": ""E-mail"",
        ""russian"": ""E-мейл"",
        ""chinese"": ""电邮"",
        ""slovak"": ""E-mail""
      },
      {
        ""identifier"": ""Username"",
        ""english"": ""Username"",
        ""russian"": ""Имя"",
        ""chinese"": ""用户名"",
        ""slovak"": ""Meno""
      },
      {
        ""identifier"": ""EmailOrUsername"",
        ""english"": ""email or username"",
        ""russian"": ""электронная почта или имя"",
        ""chinese"": ""电子邮件或用户名"",
        ""slovak"": ""e-mail alebo meno""
      },
      {
        ""identifier"": ""Password"",
        ""english"": ""Password"",
        ""russian"": ""Пароль"",
        ""chinese"": ""密码"",
        ""slovak"": ""Heslo""
      },
      {
        ""identifier"": ""VerificationCode"",
        ""english"": ""verification code"",
        ""russian"": ""код подтверждения"",
        ""chinese"": ""验证码"",
        ""slovak"": ""overovací kód""
      },
      {
        ""identifier"": ""ChooseLanguage"",
        ""english"": ""Choose language"",
        ""russian"": ""Выберите язык"",
        ""chinese"": ""选择语言"",
        ""slovak"": ""Zvoľte jazyk""       
      },
      {
        ""identifier"": ""English"",
        ""english"": ""English"",
        ""russian"": ""Английский"",
        ""chinese"": ""英语"",
        ""slovak"": ""Anglický""
      },
      {
        ""identifier"": ""Russian"",
        ""english"": ""Russian"",
        ""russian"": ""Русский"",
        ""chinese"": ""俄语"",
        ""slovak"": ""Ruský""
      },
      {
        ""identifier"": ""Chinese"",
        ""english"": ""Chinese"",
        ""russian"": ""Китайский"",
        ""chinese"": ""俄语"",
        ""slovak"": ""Čínsky""
      },
      {
        ""identifier"": ""Slovak"",
        ""english"": ""Slovak"",
        ""russian"": ""Cловацкий"",
        ""chinese"": ""斯洛伐克语"",
        ""slovak"": ""Slovenský""
      },
      {
        ""identifier"": ""Guest"",
        ""english"": ""Guest"",
        ""russian"": ""Гость"",
        ""chinese"": ""访客帐户"",
        ""slovak"": ""Hosť""       
      },
      {
        ""identifier"": ""ChooseCountry"",
        ""english"": ""Please, choose your country"",
        ""russian"": ""Пожалуйста, выберите вашу страну"",
        ""chinese"": ""请选择您的国家"",
        ""slovak"": ""Prosím, zvoľte svoju krajinu""       
      },
      {
        ""identifier"": ""Settings"",
        ""english"": ""Settings"",
        ""russian"": ""Настройки"",
        ""chinese"": ""设置"",
        ""slovak"": ""Nastavenia""
      },
      {
        ""identifier"": ""Language"",
        ""english"": ""Language"",
        ""russian"": ""Язык"",
        ""chinese"": ""语言"",
        ""slovak"": ""Jazyk""       
      },
      {
        ""identifier"": ""ScreenResolution"",
        ""english"": ""Screen resolution"",
        ""russian"": ""Разрешение экрана"",
        ""chinese"": ""屏幕分辨率"",
        ""slovak"": ""Rozlíšenie obrazovky""       
      },
      {
        ""identifier"": ""PrimaryColor"",
        ""english"": ""Primary color"",
        ""russian"": ""Основной цвет"",
        ""chinese"": ""原色"",
        ""slovak"": ""Primárna farba""
      },
      {
        ""identifier"": ""SecondaryColor"",
        ""english"": ""Secondary color"",
        ""russian"": ""Вторичный цвет"",
        ""chinese"": ""次要颜色"",
        ""slovak"": ""Sekundárna farba""
      },
      {
        ""identifier"": ""BackgroundColor"",
        ""english"": ""Background color"",
        ""russian"": ""Цвет фона"",
        ""chinese"": ""背景颜色"",
        ""slovak"": ""Farba pozadia""
      },
      {
        ""identifier"": ""SecondaryBackgroundColor"",
        ""english"": ""Secondary background color"",
        ""russian"": ""Дополнительный цвет фона"",
        ""chinese"": ""辅助背景颜色"",
        ""slovak"": ""Sekundárna farba pozadia""
      },
      {
        ""identifier"": ""NegativeColor"",
        ""english"": ""Negative color"",
        ""russian"": ""Отрицательный цвет"",
        ""chinese"": ""负界面颜色"",
        ""slovak"": ""Negatívna farba""
      },
      {
        ""identifier"": ""Music"",
        ""english"": ""Music"",
        ""russian"": ""Музыка"",
        ""chinese"": ""音乐"",
        ""slovak"": ""Hudba""       
      },
      {
        ""identifier"": ""Account"",
        ""english"": ""Account"",
        ""russian"": ""Счет"",
        ""chinese"": ""帐户"",
        ""slovak"": ""Účet""       
      },
      {
        ""identifier"": ""Interface"",
        ""english"": ""Interface"",
        ""russian"": ""Интерфейс"",
        ""chinese"": ""用户界面"",
        ""slovak"": ""Interface""       
      },
      {
        ""identifier"": ""Gameplay"",
        ""english"": ""Gameplay"",
        ""russian"": ""Геймплей"",
        ""chinese"": ""游戏"",
        ""slovak"": ""Hrateľnosť""       
      },
      {
        ""identifier"": ""Country"",
        ""english"": ""Country"",
        ""russian"": ""Страна"",
        ""chinese"": ""国家"",
        ""slovak"": ""Krajina""       
      },
      {
        ""identifier"": ""Start"",
        ""english"": ""Start"",
        ""russian"": ""Начать"",
        ""chinese"": ""开始"",
        ""slovak"": ""Začať""
      },
      {
        ""identifier"": ""Back"",
        ""english"": ""Back"",
        ""russian"": ""Назад"",
        ""chinese"": ""后退"",
        ""slovak"": ""Späť""
      },
      {
        ""identifier"": ""Next"",
        ""english"": ""Next"",
        ""russian"": ""Далее"",
        ""chinese"": ""下一个"",
        ""slovak"": ""Ďalší""
      },
      {
        ""identifier"": ""Recover"",
        ""english"": ""Recover"",
        ""russian"": ""Восстановить"",
        ""chinese"": ""恢复"",
        ""slovak"": ""Obnoviť""
      },
      {
        ""identifier"": ""Send"",
        ""english"": ""Send"",
        ""russian"": ""Отправить"",
        ""chinese"": ""发送"",
        ""slovak"": ""Odoslať""
      },
      {
        ""identifier"": ""Strength"",
        ""english"": ""Strength:"",
        ""russian"": ""Сила:"",
        ""chinese"": ""力量:"",
        ""slovak"": ""Sila:""
      },
      {
        ""identifier"": ""Perception"",
        ""english"": ""Perception:"",
        ""russian"": ""Восприятие:"",
        ""chinese"": ""知觉:"",
        ""slovak"": ""Vnímanie:""
      },
      {
        ""identifier"": ""Intelligence"",
        ""english"": ""Intelligence:"",
        ""russian"": ""Интеллект:"",
        ""chinese"": ""智力:"",
        ""slovak"": ""Inteligencia:""
      },
      {
        ""identifier"": ""Agility"",
        ""english"": ""Agility:"",
        ""russian"": ""Ловкость:"",
        ""chinese"": ""敏捷:"",
        ""slovak"": ""Obratnosť:""
      },
      {
        ""identifier"": ""Charisma"",
        ""english"": ""Charisma:"",
        ""russian"": ""Харизма:"",
        ""chinese"": ""魅力:"",
        ""slovak"": ""Charizma:""
      },
      {
        ""identifier"": ""Willpower"",
        ""english"": ""Willpower:"",
        ""russian"": ""Сила воли:"",
        ""chinese"": ""意志:"",
        ""slovak"": ""Sila vôle:""
      },
      {
        ""identifier"": ""Stats"",
        ""english"": ""Stats"",
        ""russian"": ""Статистика"",
        ""chinese"": ""统计数据"",
        ""slovak"": ""Vlastnosti""
      },
      {
        ""identifier"": ""Skills"",
        ""english"": ""Skills"",
        ""russian"": ""Навыки"",
        ""chinese"": ""技能"",
        ""slovak"": ""Zručnosti""
      },
      {
        ""identifier"": ""Status"",
        ""english"": ""Status"",
        ""russian"": ""Cтатус"",
        ""chinese"": ""地位"",
        ""slovak"": ""Stav""
      },
      {
        ""identifier"": ""StatusReport"",
        ""english"": ""Status report"",
        ""russian"": ""Отчет"",
        ""chinese"": ""状况报告"",
        ""slovak"": ""Hlásenie správy""
      },
      {
        ""identifier"": ""StatusReportDesc"",
        ""english"": ""Your spacecraft shook violently as it descended towards the unknown planet's surface. The crew held onto their seats, trying to brace themselves for the inevitable crash. With a loud bang, the ship hit the ground, sending debris flying everywhere. You've been able to salvage some resources but found the rest of the crew dead."",
        ""russian"": ""Космический корабль сильно трясло, когда он спускался к поверхности неизвестной планеты. Экипаж держался за свои места, пытаясь подготовиться к неизбежному столкновению. С громким грохотом корабль ударился о землю, разбрасывая во все стороны обломки. Вам удалось спасти некоторые материалы, но больше никого не было в живых."",
        ""chinese"": ""飞船剧烈一晃，降落在了一颗未知星球的地表。机组人员紧紧抓住他们的座位，试图为不可避免的坠机做准备。一声巨响，船身重重的撞在了地面上，碎屑飞扬。您已经能够挽救一些材料，但没有其他人幸存下来。"",
        ""slovak"": ""Kozmická loď sa prudko otriasala, keď klesala k povrchu neznámej planéty. Posádka sa držala svojich sedadiel a snažila sa pripraviť na nevyhnutný náraz. S hlasným treskom loď dopadla na zem a trosky lietali všade. Podarilo sa vám pozbierař nejaké materiály, no nikto iný neostal na žive.""
      },
      {
        ""identifier"": ""FriendsPanel"",
        ""english"": ""Friends panel"",
        ""russian"": ""Панель друзей"",
        ""chinese"": ""显示好友菜单"",
        ""slovak"": ""Panel priateľov""
      },
      {
        ""identifier"": ""CrashLanding"",
        ""english"": ""Crash landing"",
        ""russian"": ""Аварийная посадка"",
        ""chinese"": ""迫降"",
        ""slovak"": ""Nárazové pristátie""
      },
      {
        ""identifier"": ""FriendRequestList"",
        ""english"": ""Friend request list"",
        ""russian"": ""Запросы в друзья"",
        ""chinese"": ""好友请求列表"",
        ""slovak"": ""Žiadosti o priateľstvá""
      },
      {
          ""identifier"": ""GroupRequestList"",
          ""english"": ""Group request list"",
          ""russian"": ""Список запросов в группу"",
          ""chinese"": ""群组请求列表"",
          ""slovak"": ""Zoznam žiadostí do skupiny""
      },
      {
        ""identifier"": ""Submit"",
        ""english"": ""Submit"",
        ""russian"": ""Подтверждать"",
        ""chinese"": ""确认"",
        ""slovak"": ""Potvrdiť""
      },
      {
        ""identifier"": ""SyncingData"",
        ""english"": ""SYNCING DATA"",
        ""russian"": ""Загрузка данных"",
        ""chinese"": ""加载数据中"",
        ""slovak"": ""NAČÍTAVAM DATA""
      },
      {
        ""identifier"": ""InitializingGame"",
        ""english"": ""INITIALIZING GAME..."",
        ""russian"": ""НИЦИАЛИЗАЦИЯ ИГРЫ..."",
        ""chinese"": ""游戏初始化中..."",
        ""slovak"": ""INICIALIZÁCIA HRY...""
      },
      {
        ""identifier"": ""Registered"",
        ""english"": ""Registered"",
        ""russian"": ""Зарегистрирован"",
        ""chinese"": ""挂号的"",
        ""slovak"": ""Registrovaný""
      },
      {
        ""identifier"": ""NotRegistered"",
        ""english"": ""Not registered"",
        ""russian"": ""Не зарегистрирован"",
        ""chinese"": ""未注册"",
        ""slovak"": ""Neregistrovaný""
      },
      {
        ""identifier"": ""Objective"",
        ""english"": ""Objective:"",
        ""russian"": ""Цель:"",
        ""chinese"": ""客观的:"",
        ""slovak"": ""Cieľ:""
      },
      {
        ""identifier"": ""Hunger"",
        ""english"": ""Hunger"",
        ""russian"": ""Голод"",
        ""chinese"": ""饥饿"",
        ""slovak"": ""Hlad""
      },
      {
        ""identifier"": ""StartNewGame"",
        ""english"": ""Start new game"",
        ""russian"": ""Начать новую игру"",
        ""chinese"": ""开始新游戏"",
        ""slovak"": ""Začať novú hru""
      },
      {
        ""identifier"": ""StartBattle"",
        ""english"": ""Start battle"",
        ""russian"": ""Начать бойу"",
        ""chinese"": ""开始战斗"",
        ""slovak"": ""Začať boj""
      },
      {
        ""identifier"": ""EmptySlot1"",
        ""english"": ""Empty slot 1"",
        ""russian"": ""Пустой слот 1"",
        ""chinese"": ""空插槽 1"",
        ""slovak"": ""Prázdny slot 1""
      },
      {
        ""identifier"": ""EmptySlot2"",
        ""english"": ""Empty slot 2"",
        ""russian"": ""Пустой слот 2"",
        ""chinese"": ""空插槽 2"",
        ""slovak"": ""Prázdny slot 2""
      },
      {
        ""identifier"": ""EmptySlot3"",
        ""english"": ""Empty slot 3"",
        ""russian"": ""Пустой слот 3"",
        ""chinese"": ""空插槽 3"",
        ""slovak"": ""Prázdny slot 3""
      },
      {
        ""identifier"": ""EmptySlot4"",
        ""english"": ""Empty slot 4"",
        ""russian"": ""Пустой слот 4"",
        ""chinese"": ""空插槽 4"",
        ""slovak"": ""Prázdny slot 4""
      },
      {
        ""identifier"": ""PrivacyPolicy"",
        ""english"": ""Privacy policy"",
        ""russian"": ""Политика конфиденциальности"",
        ""chinese"": ""隐私政策"",
        ""slovak"": ""Zásady ochrany osobných údajov""
      },
      {
        ""identifier"": ""Blueprint"",
        ""english"": "" - (Blueprint)"",
        ""russian"": "" - (План)"",
        ""chinese"": "" - (蓝图)"",
        ""slovak"": "" - (Plán)""
      },
      {
        ""identifier"": ""ALLBLUEPRINTS"",
        ""english"": ""All blueprints"",
        ""russian"": ""Все чертежи"",
        ""chinese"": ""所有蓝图"",
        ""slovak"": ""Všetky plány""
      },
      {
        ""identifier"": ""ALLITEMS"",
        ""english"": ""All items"",
        ""russian"": ""Все предметы"",
        ""chinese"": ""万物"",
        ""slovak"": ""Všetky veci""
      },
      {
        ""identifier"": ""BASIC"",
        ""english"": ""Basic"",
        ""russian"": ""Основные"",
        ""chinese"": ""基础产品"",
        ""slovak"": ""Základné""
      },
      {
        ""identifier"": ""PROCESSED"",
        ""english"": ""Processed"",
        ""russian"": ""Обработанные"",
        ""chinese"": ""处理过的产品"",
        ""slovak"": ""Spracované""
      },
      {
        ""identifier"": ""ENHANCED"",
        ""english"": ""Enhanced"",
        ""russian"": ""Улучшенные"",
        ""chinese"": ""强化产品"",
        ""slovak"": ""Upravené""
      },
      {
        ""identifier"": ""ASSEMBLED"",
        ""english"": ""Assembled"",
        ""russian"": ""Собранные"",
        ""chinese"": ""组装产品"",
        ""slovak"": ""Zostavené""
      },
      {
        ""identifier"": ""BUILDINGS"",
        ""english"": ""Buildings"",
        ""russian"": ""Здания"",
        ""chinese"": ""建筑物"",
        ""slovak"": ""Budovy""
      },
      {
        ""identifier"": ""ALLTYPES"",
        ""english"": ""All Types"",
        ""russian"": ""Все типы"",
        ""chinese"": ""所有类型"",
        ""slovak"": ""Všetky typy""
      },
      {
        ""identifier"": ""PLANTS"",
        ""english"": ""Plants"",
        ""russian"": ""Растения"",
        ""chinese"": ""植物"",
        ""slovak"": ""Rastliny""
      },
      {
        ""identifier"": ""LIQUID"",
        ""english"": ""Liquid"",
        ""russian"": ""Жидкость"",
        ""chinese"": ""液体"",
        ""slovak"": ""Tekutiny""
      },
      {
        ""identifier"": ""MINERALS"",
        ""english"": ""Minerals"",
        ""russian"": ""Минералы"",
        ""chinese"": ""矿物质"",
        ""slovak"": ""Minerály""
      },
      {
        ""identifier"": ""GAS"",
        ""english"": ""Gas"",
        ""russian"": ""Газ"",
        ""chinese"": ""气体"",
        ""slovak"": ""Plyny""
      },
      {
        ""identifier"": ""METALS"",
        ""english"": ""Metals"",
        ""russian"": ""Металлы"",
        ""chinese"": ""金属"",
        ""slovak"": ""Kovy""
      },
      {
        ""identifier"": ""FOAM"",
        ""english"": ""Foam"",
        ""russian"": ""Пена"",
        ""chinese"": ""泡沫"",
        ""slovak"": ""Pena""
      },
      {
        ""identifier"": ""POWDERS"",
        ""english"": ""Powders"",
        ""russian"": ""Порошки"",
        ""chinese"": ""粉末"",
        ""slovak"": ""Prášky""
      },
      {
        ""identifier"": ""MEAT"",
        ""english"": ""Meat"",
        ""russian"": ""Мясо"",
        ""chinese"": ""肉"",
        ""slovak"": ""Mäso""
      },
      {
        ""identifier"": ""FABRIC"",
        ""english"": ""Fabric"",
        ""russian"": ""Ткань"",
        ""chinese"": ""织物"",
        ""slovak"": ""Látka""
      },
      {
        ""identifier"": ""WEAPONS"",
        ""english"": ""Weapons"",
        ""russian"": ""Оружие"",
        ""chinese"": ""武器"",
        ""slovak"": ""Zbrane""
      },
      {
        ""identifier"": ""ARMOR"",
        ""english"": ""Armor"",
        ""russian"": ""Броня"",
        ""chinese"": ""盔甲"",
        ""slovak"": ""Zbroj""
      },
      {
        ""identifier"": ""HELMET"",
        ""english"": ""Helmet"",
        ""russian"": ""Шлем"",
        ""chinese"": ""头盔"",
        ""slovak"": ""Prilba""
      },
      {
        ""identifier"": ""SUIT"",
        ""english"": ""Suit"",
        ""russian"": ""Костюм"",
        ""chinese"": ""太空服"",
        ""slovak"": ""Oblek""
      },
      {
        ""identifier"": ""FABRICATOR"",
        ""english"": ""Fabricator"",
        ""russian"": ""Фабрикатор"",
        ""chinese"": ""制造装置"",
        ""slovak"": ""Výrobník""
      },
      {
        ""identifier"": ""MELEEWEAPON"",
        ""english"": ""Melee weapon"",
        ""russian"": ""Оружие ближнего боя"",
        ""chinese"": ""近战武器"",
        ""slovak"": ""Zbraň na blízko""
      },
      {
        ""identifier"": ""RANGEDWEAPON"",
        ""english"": ""Ranged weapon"",
        ""russian"": ""Оружие дальнего боя"",
        ""chinese"": ""远程武器"",
        ""slovak"": ""Zbraň na diaľku""
      },
      {
        ""identifier"": ""SHIELD"",
        ""english"": ""Shield"",
        ""russian"": ""Щит"",
        ""chinese"": ""盾"",
        ""slovak"": ""Štít""
      },
      {
        ""identifier"": ""OFFHAND"",
        ""english"": ""Accessory"",
        ""russian"": ""Аксессуар"",
        ""chinese"": ""配饰"",
        ""slovak"": ""Doplnok""
      },
      {
        ""identifier"": ""ENERGY"",
        ""english"": ""Energy"",
        ""russian"": ""Энергия"",
        ""chinese"": ""能源"",
        ""slovak"": ""Energie""
      },
      {
        ""identifier"": ""OXYGEN"",
        ""english"": ""Oxygen"",
        ""russian"": ""Кислород"",
        ""chinese"": ""氧气"",
        ""slovak"": ""Kyslík""
      },
      {
        ""identifier"": ""MINING"",
        ""english"": ""Mining"",
        ""russian"": ""Добыча"",
        ""chinese"": ""采矿"",
        ""slovak"": ""Ťažba""
      },
      {
        ""identifier"": ""BAG"",
        ""english"": ""Bag"",
        ""russian"": ""Сумка"",
        ""chinese"": ""袋子"",
        ""slovak"": ""Taška""
      },
      {
        ""identifier"": ""AGRICULTURE"",
        ""english"": ""Agriculture"",
        ""russian"": ""Cельское хозяйство"",
        ""chinese"": ""农业设施"",
        ""slovak"": ""Poľnohospodárstvo""
      },
      {
        ""identifier"": ""PUMPINGFACILITY"",
        ""english"": ""Pumping facility"",
        ""russian"": ""Насосная установка"",
        ""chinese"": ""抽水设施"",
        ""slovak"": ""Čerpacie zariadenie""
      },
      {
        ""identifier"": ""FACTORY"",
        ""english"": ""Factory"",
        ""russian"": ""Фабрика"",
        ""chinese"": ""工厂"",
        ""slovak"": ""Fabrika""
      },
      {
        ""identifier"": ""COMMFACILITY"",
        ""english"": ""Comm facility"",
        ""russian"": ""Средства связи"",
        ""chinese"": ""通讯设施"",
        ""slovak"": ""Komunikačné zariadenie""
      },
      {
        ""identifier"": ""LABORATORY"",
        ""english"": ""Laboratory"",
        ""russian"": ""Лаборатория"",
        ""chinese"": ""实验室"",
        ""slovak"": ""Laboratórium""
      },
      {
        ""identifier"": ""STORAGEHOUSE"",
        ""english"": ""Storage house"",
        ""russian"": ""Складское помещение"",
        ""chinese"": ""储藏室"",
        ""slovak"": ""Skladový dom""
      },
      {
        ""identifier"": ""NAVALFACILITY"",
        ""english"": ""Naval facility"",
        ""russian"": ""Военно-морской объект"",
        ""chinese"": ""海军设施"",
        ""slovak"": ""Námorné zariadenie""
      },
      {
        ""identifier"": ""OXYGENFACILITY"",
        ""english"": ""Oxygen facility"",
        ""russian"": ""Кислородная установка"",
        ""chinese"": ""制氧设施"",
        ""slovak"": ""Kyslíkové zariadenie""
      },
      {
        ""identifier"": ""AVIATIONFACILITY"",
        ""english"": ""Aviation facility"",
        ""russian"": ""Авиационный объект"",
        ""chinese"": ""航空设施"",
        ""slovak"": ""Letecké zariadenie""
      },
      {
        ""identifier"": ""HEATINGFACILITY"",
        ""english"": ""Heating facility"",
        ""russian"": ""Отопительная установка"",
        ""chinese"": ""供暖设施"",
        ""slovak"": ""Vykurovacie zariadenie""
      },
      {
        ""identifier"": ""COOLINGFACILITY"",
        ""english"": ""Cooling facility"",
        ""russian"": ""Охлаждающая установка"",
        ""chinese"": ""冷却设施"",
        ""slovak"": ""Chladiace zariadenie""
      },
      {
        ""identifier"": ""POWERPLANT"",
        ""english"": ""Powerplant"",
        ""russian"": ""Электростанция"",
        ""chinese"": ""发电厂"",
        ""slovak"": ""Elektráreň""
      },
      {
        ""identifier"": ""OXYGENSTATION"",
        ""english"": ""Oxygen station"",
        ""russian"": ""Кислородная станция"",
        ""chinese"": ""氧气站"",
        ""slovak"": ""Kyslíková stanica""
      },
      {
        ""identifier"": ""MININGRIG"",
        ""english"": ""Mining rig"",
        ""russian"": ""Горная установка"",
        ""chinese"": ""采矿设施"",
        ""slovak"": ""Ťažobné zariadenie""
      },
      {
        ""identifier"": ""ALLCLASSES"",
        ""english"": ""All classes"",
        ""russian"": ""Все классы"",
        ""chinese"": ""所有等级"",
        ""slovak"": ""Všetky triedy""
      },
      {
        ""identifier"": ""CLASS-F"",
        ""english"": ""Class-F"",
        ""russian"": ""Класс-F"",
        ""chinese"": ""等级-F"",
        ""slovak"": ""Trieda-F""
      },
      {
        ""identifier"": ""CLASS-E"",
        ""english"": ""Class-E"",
        ""russian"": ""Класс-E"",
        ""chinese"": ""等级-E"",
        ""slovak"": ""Trieda-E""
      },
      {
        ""identifier"": ""CLASS-D"",
        ""english"": ""Class-D"",
        ""russian"": ""Класс-D"",
        ""chinese"": ""等级-D"",
        ""slovak"": ""Trieda-D""
      },
      {
        ""identifier"": ""CLASS-C"",
        ""english"": ""Class-C"",
        ""russian"": ""Класс-C"",
        ""chinese"": ""等级-C"",
        ""slovak"": ""Trieda-C""
      },
      {
        ""identifier"": ""CLASS-B"",
        ""english"": ""Class-B"",
        ""russian"": ""Класс-B"",
        ""chinese"": ""等级-B"",
        ""slovak"": ""Trieda-B""
      },
      {
        ""identifier"": ""CLASS-A"",
        ""english"": ""Class-A"",
        ""russian"": ""Класс-A"",
        ""chinese"": ""等级-A"",
        ""slovak"": ""Trieda-A""
      },
      {
        ""identifier"": ""CLASS-S"",
        ""english"": ""Class-S"",
        ""russian"": ""Класс-S"",
        ""chinese"": ""等级-S"",
        ""slovak"": ""Trieda-S""
      },
      {
        ""identifier"": ""Exploration"",
        ""english"": ""Exploration"",
        ""russian"": ""Исследование"",
        ""chinese"": ""勘探"",
        ""slovak"": ""Prieskum""
      },
      {
        ""identifier"": ""Production"",
        ""english"": ""Production"",
        ""russian"": ""Производство"",
        ""chinese"": ""生产"",
        ""slovak"": ""Výroba""
      },
      {
        ""identifier"": ""Inventory"",
        ""english"": ""Inventory"",
        ""russian"": ""Инвентарь"",
        ""chinese"": ""存货"",
        ""slovak"": ""Inventár""
      },
      {
        ""identifier"": ""Base"",
        ""english"": ""Base"",
        ""russian"": ""База"",
        ""chinese"": ""基地"",
        ""slovak"": ""Základňa""
      },
      {
        ""identifier"": ""Overview"",
        ""english"": ""Overview"",
        ""russian"": ""Обзор"",
        ""chinese"": ""概述"",
        ""slovak"": ""Prehľad""
      },
      {
        ""identifier"": ""Planning"",
        ""english"": ""Planning"",
        ""russian"": ""Планирование"",
        ""chinese"": ""规划"",
        ""slovak"": ""Plánovanie""
      },
      {
        ""identifier"": ""LifeSupport"",
        ""english"": ""Life support"",
        ""russian"": ""жизнеобеспечение"",
        ""chinese"": ""生命保障"",
        ""slovak"": ""Životná podpora""
      },
      {
        ""identifier"": ""ManualProduction"",
        ""english"": ""Manual production"",
        ""russian"": ""Ручное производство"",
        ""chinese"": ""手工制作"",
        ""slovak"": ""Manuálna výroba""
      },
      {
        ""identifier"": ""PlanetIndex"",
        ""english"": ""Planet index"",
        ""russian"": ""Индекс планеты"",
        ""chinese"": ""行星指数"",
        ""slovak"": ""Planetárny index""
      },
      {
        ""identifier"": ""PlanetIndexDesc"",
        ""english"": ""Represents the overall planetary quality index by calculating each planetary resource and its overall impact on human well-being."",
        ""russian"": ""Представляет общий планетарный индекс качества путем расчета каждого ресурса планеты и его общего влияния на благосостояние людей."",
        ""chinese"": ""该指数通过计算地球所具有的每一种状况及其对人类福祉的总体影响来代表整体星球质量指数。"",
        ""slovak"": ""Predstavuje celkový index planetárnej kvality výpočtom každého planetárneho zdroja a jeho celkového vplyvu na ľudské blaho.""
      },
      {
        ""identifier"": ""Objective"",
        ""english"": ""Objective"",
        ""russian"": ""Задача"",
        ""chinese"": ""任务"",
        ""slovak"": ""Úloha""
      },
      {
        ""identifier"": ""CraftBatteryDesc"",
        ""english"": ""Your suit needs energy to function. Craft all necessary materials in order to craft battery (<color=yellow>Fibrous leaves</color> + <color=yellow>Bio fuel</color> + <color=yellow>Battery Core</color>)."",
        ""russian"": ""Ваш скафандр нуждается в энергии, чтобы функционировать. Создайте все необходимые материалы для изготовления батареи (<color=yellow>Волокнистые листья</color> + <color=yellow>Биотопливо</color> + <color=yellow>Ядро батареи</color>)."",
        ""chinese"": ""你的宇航服需要能量才能正常工作。 制作所有这些物品来制作电池 (<color=yellow>纤维叶</color> + <color=yellow>生物燃料</color> + <color=yellow>电芯</color>)."",
        ""slovak"": ""Váš oblek potrebuje energiu na fungovanie. Najprv vyrobte všetky potrebné veci, aby ste mohli zostrojiť batériu. (<color=yellow>Vláknité listy</color> + <color=yellow>Biopalivo</color> + <color=yellow>Jadro batérie</color>).""
      },
      {
        ""identifier"": ""CraftAndUseWaterDesc"",
        ""english"": ""Craft <color=yellow>[Purified Water]</color>. Then go to <color=yellow>[Inventory]</color> and use drag and drop to put it into the <color=yellow>[Water slot]</color>."",
        ""russian"": ""Создайте <color=yellow>[Дистиллированную воду]</color> и перейдите в меню <color=yellow>[Инвентарь]</color>. Перетащите его значок на <color=yellow>[Резервуар для воды]</color>."",
        ""chinese"": ""创建<color=yellow>[蒸馏水]</color>并转到<color=yellow>[库存]</color>菜单。将其图标拖至<color=yellow>[水箱]</color>。"",
        ""slovak"": ""Vytvorte <color=yellow>[Destilovanú vodu]</color> a prejdite do menu <color=yellow>[Inventár]</color>. Potiahnite jej ikonu do <color=yellow>[Zásobníka vody]</color>.""
      },
      {
        ""identifier"": ""BuildBaseDesc"",
        ""english"": ""Build a <color=yellow>Bio fuel Generator</color> in the <color=yellow>[Production]</color> tab. Then go to the <color=yellow>[Base]</color> tab and drag its icon inside the construction grid."",
        ""russian"": ""Создайте <color=yellow>Генератор биотоплива</color> на вкладке <color=yellow>[Производство]</color>. Затем перейдите на вкладку <color=yellow>[Base]</color> и перетащите ее значок внутрь сетки построения."",
        ""chinese"": ""在<color=yellow>[生产]</color>选项卡中构建<color=yellow>生物燃料发电机</color>。然后转到<color=yellow>[基地建设]</color>选项卡并将其图标拖动到构造网格内。"",
        ""slovak"": ""Zostavte <color=yellow>Generátor biopalív</color> na karte <color=yellow>[Produkcia]</color>. Potom prejdite na kartu <color=yellow>[Základňa]</color> a presuňte jej ikonu do konštrukčnej mriežky.""
      },
      {
        ""identifier"": ""BiologySkill"",
        ""english"": ""Biology skill"",
        ""russian"": ""Навык биологии"",
        ""chinese"": ""生物学技能"",
        ""slovak"": ""Biologická zručnosť""
      },
      {
        ""identifier"": ""BiologySkillDesc"",
        ""english"": ""- required for more complex plant or flesh based products - discovers new types and more complex recipes - useful in combat against biological targets"",
        ""russian"": ""- требуется для более сложных продуктов на растительной или мясной основе - открывает новые типы и более сложные рецепты - полезен в борьбе с биологическими целями"",
        ""chinese"": ""- 更复杂的植物或肉类产品需要此技能 - 发现新类型和更复杂的食谱 - 有助于对抗生物目标"",
        ""slovak"": ""- vyžaduje sa pre zložitejšie rastlinné alebo mäsové výrobky - objavuje nové druhy a zložitejšie recepty - užitočné v boji proti biologickým cieľom""
      },
      {
        ""identifier"": ""ChemistrySkill"",
        ""english"": ""Chemistry skill"",
        ""russian"": ""Химический навык"",
        ""chinese"": ""化学技能"",
        ""slovak"": ""Chemické zručnosti""
      },
      {
        ""identifier"": ""ChemistrySkillDesc"",
        ""english"": ""Plants, Liquid and Powders production speed  + 1% per level."",
        ""russian"": ""Скорость производства установок, жидкостей и порошков +1% за уровень."",
        ""chinese"": ""+1% 植物、液体和粉末生产速度"",
        ""slovak"": ""Rýchlosť výroby rastlín, tekutín a práškov + 1 % za každú úroveň.""
      },
      {
        ""identifier"": ""EngineeringSkill"",
        ""english"": ""Engineering skill"",
        ""russian"": ""Инженерное мастерство"",
        ""chinese"": ""工程技能"",
        ""slovak"": ""Inžinierske zručnosti""
      },
      {
        ""identifier"": ""EngineeringSkillDesc"",
        ""english"": ""Mining and construction + 1% per level."",
        ""russian"": ""Горное дело и строительство +1% за уровень."",
        ""chinese"": ""采矿和建筑 + 每级 1%。"",
        ""slovak"": ""Ťažba a stavebníctvo + 1 % za úroveň.""
      },
      {
        ""identifier"": ""AutoUse"",
        ""english"": ""Automatic use"",
        ""russian"": ""Автоматическое использование"",
        ""chinese"": ""自动使用"",
        ""slovak"": ""Automatické použitie""
      },
      {
        ""identifier"": ""AutoUseDesc"",
        ""english"": ""AWhen a given item runs out, another item of the same type is automatically set from the inventory."",
        ""russian"": ""Когда данный предмет заканчивается, из инвентаря автоматически выбирается другой предмет того же типа."",
        ""chinese"": ""当给定的物品用完时，会自动从库存中设置另一件相同类型的物品。"",
        ""slovak"": ""Keď sa daný predmet minie, automaticky sa z inventára nastaví ďalší predmet rovnakého typu.""
      },
      {
        ""identifier"": ""NotEnoughMaterials"",
        ""english"": ""Not enough materials!"",
        ""russian"": ""Недостаточно материалов!"",
        ""chinese"": ""材料不够！"",
        ""slovak"": ""Nedostatok materiálov!""
      },
      {
        ""identifier"": ""AutomateBattery"",
        ""english"": ""Automate battery production"",
        ""russian"": ""Автоматизируйте производство аккумуляторов"",
        ""chinese"": ""实现电池生产自动化"",
        ""slovak"": ""Automatizujte výrobu batérií""
      },
      {
        ""identifier"": ""BuildBase"",
        ""english"": ""Build and place the first building"",
        ""russian"": ""Постройте и разместите свое первое здание"",
        ""chinese"": ""建造并放置第一座建筑物"",
        ""slovak"": ""Postavte a umiestnite svoju prvú budovu""
      },
      {
        ""identifier"": ""CraftAndUseWater"",
        ""english"": ""Craft and use distilled water"",
        ""russian"": ""Создайте и используйте дистиллированную воду"",
        ""chinese"": ""让我们制作并使用蒸馏水!"",
        ""slovak"": ""Pripravte a použite destilovanú vodu""
      },
      {
        ""identifier"": ""CraftBattery"",
        ""english"": ""Craft a battery"",
        ""russian"": ""Создайте батарею"",
        ""chinese"": ""做电池吧！"",
        ""slovak"": ""Vyrobte batériu!""
      },
      {
        ""identifier"": ""IronSheet"",
        ""english"": ""Iron sheet"",
        ""russian"": ""Железный лист"",
        ""chinese"": ""铁皮"",
        ""slovak"": ""Železný plech""
      },
      {
        ""identifier"": ""IronSheetDesc"",
        ""english"": ""Material required for building advanced metal products."",
        ""russian"": ""Материал, необходимый для изготовления современных металлических изделий."",
        ""chinese"": ""这是制造先进金属产品所需的常见材料。"",
        ""slovak"": ""Materiál potrebný na výrobu pokročilých kovových výrobkov.""
      },
      {
        ""identifier"": ""IronRod"",
        ""english"": ""Iron rod"",
        ""russian"": ""Железный стержень"",
        ""chinese"": ""铁棒"",
        ""slovak"": ""Železná tyč""
      },
      {
        ""identifier"": ""IronRodDesc"",
        ""english"": ""Standard component of metallurgical products."",
        ""russian"": ""Стандартный компонент металлургической продукции."",
        ""chinese"": ""铁棒是冶金产品的标准件。"",
        ""slovak"": ""Bežný prvok hutníckych výrobkov.""
      },
      {
        ""identifier"": ""IronTube"",
        ""english"": ""Iron tube"",
        ""russian"": ""Железная трубка"",
        ""chinese"": ""铁管"",
        ""slovak"": ""Železná trubka""
      },
      {
        ""identifier"": ""IronTubeDesc"",
        ""english"": ""Standard building component for handling fluids or gas."",
        ""russian"": ""Стандартный строительный компонент для работы с жидкостями или газом."",
        ""chinese"": ""这是用于处理流体或气体的标准建筑组件。"",
        ""slovak"": ""Štandardný stavebný prvok na manipuláciu s kvapalinami alebo plynmi.""
      },
      {
        ""identifier"": ""Movement"",
        ""english"": ""Movement"",
        ""russian"": ""Движение"",
        ""chinese"": ""移动"",
        ""slovak"": ""Pohyb""
      },
      {
        ""identifier"": ""Weather"",
        ""english"": ""Weather"",
        ""russian"": ""Погода"",
        ""chinese"": ""天气"",
        ""slovak"": ""Počasie""
      },
      {
        ""identifier"": ""Route"",
        ""english"": ""Route"",
        ""russian"": ""Маршрут"",
        ""chinese"": ""路线"",
        ""slovak"": ""Trasa""
      },
      {
        ""identifier"": ""Visibility"",
        ""english"": ""Visibility"",
        ""russian"": ""Видимость"",
        ""chinese"": ""能见度"",
        ""slovak"": ""Viditeľnosť""
      },
      {
        ""identifier"": ""PerceptionArea"",
        ""english"": ""Perception area"",
        ""russian"": ""Область восприятия"",
        ""chinese"": ""感知区"",
        ""slovak"": ""Oblasť vnímania""
      },
      {
        ""identifier"": ""PickupRadius"",
        ""english"": ""Pick-up radius"",
        ""russian"": ""Круг сбора"",
        ""chinese"": ""物品拾取距离"",
        ""slovak"": ""Okruh zberu""
      },
      {
        ""identifier"": ""Movement"",
        ""english"": ""Movement"",
        ""russian"": ""Движение"",
        ""chinese"": ""移动"",
        ""slovak"": ""Pohyb""
      },
      {
        ""identifier"": ""Durability"",
        ""english"": ""Durability:"",
        ""russian"": ""Долговечность:"",
        ""chinese"": ""耐用性:"",
        ""slovak"": ""Trvanlivosť:""
      },
      {
        ""identifier"": ""PhysicalProtection"",
        ""english"": ""Physical protection:"",
        ""russian"": ""Физическая защита:"",
        ""chinese"": ""物理保护:"",
        ""slovak"": ""Fyzická ochrana:""
      },
      {
        ""identifier"": ""FireProtection"",
        ""english"": ""Fire protection:"",
        ""russian"": ""Огнестойкость:"",
        ""chinese"": ""防火性能:"",
        ""slovak"": ""Ochrana proti ohňu:""
      },
      {
        ""identifier"": ""ColdProtection"",
        ""english"": ""Cold protection:"",
        ""russian"": ""Холодостойкость:"",
        ""chinese"": ""耐寒性:"",
        ""slovak"": ""Ochrana proti chladu:""
      },
      {
        ""identifier"": ""PoisonProtection"",
        ""english"": ""Poison protection:"",
        ""russian"": ""Защита от яда:"",
        ""chinese"": ""毒抗性:"",
        ""slovak"": ""Ochrana pred jedmi:""
      },
      {
        ""identifier"": ""EnergyProtection"",
        ""english"": ""Energy protection:"",
        ""russian"": ""Защита от энергии:"",
        ""chinese"": ""能量防护:"",
        ""slovak"": ""Ochrana proti energií:""
      },
      {
        ""identifier"": ""ShieldPoints"",
        ""english"": ""Shield points:"",
        ""russian"": ""Очки щита:"",
        ""chinese"": ""护盾点数:"",
        ""slovak"": ""Body štítu:""
      },
      {
        ""identifier"": ""Armor"",
        ""english"": ""Armor"",
        ""russian"": ""Броня"",
        ""chinese"": ""盔甲"",
        ""slovak"": ""Brnenie""
      },
      {
        ""identifier"": ""HitPoints"",
        ""english"": ""Hit points:"",
        ""russian"": ""Очки жизни:"",
        ""chinese"": ""命值点:"",
        ""slovak"": ""Body zdravia:""
      },
      {
        ""identifier"": ""AttackSpeed"",
        ""english"": ""Attack speed:"",
        ""russian"": ""Скорость атаки:"",
        ""chinese"": ""攻击速度:"",
        ""slovak"": ""Rýchlosť útoku:""
      },
      {
        ""identifier"": ""MeleeDamage"",
        ""english"": ""Melee damage:"",
        ""russian"": ""Урон в ближнем бою:"",
        ""chinese"": ""近战伤害:"",
        ""slovak"": ""Poškodenie zblízka:""
      },
      {
        ""identifier"": ""RangedDamage"",
        ""english"": ""Ranged damage:"",
        ""russian"": ""Урон дальнего боя:"",
        ""chinese"": ""远程伤害:"",
        ""slovak"": ""Poškodenie na diaľku:""
      },
      {
        ""identifier"": ""MeleePhysicalDamage"",
        ""english"": ""Melee physical damage:"",
        ""russian"": ""Физический урон в ближнем бою:"",
        ""chinese"": ""近战物理伤害:"",
        ""slovak"": ""Fyzické poškodenie na blízko:""
      },
      {
        ""identifier"": ""MeleeFireDamage"",
        ""english"": ""Melee fire damage:"",
        ""russian"": ""Урон огнем в ближнем бою:"",
        ""chinese"": ""近战火焰伤害:"",
        ""slovak"": ""Ohnivé poškodenie na blízko:""
      },
      {
        ""identifier"": ""MeleeColdDamage"",
        ""english"": ""Melee cold damage:"",
        ""russian"": ""Холодный урон в ближнем бою:"",
        ""chinese"": ""近战冰冷伤害:"",
        ""slovak"": ""Ľadové poškodenie na blízko:""
      },
      {
        ""identifier"": ""MeleePoisonDamage"",
        ""english"": ""Melee poison damage:"",
        ""russian"": ""Урон ядом в ближнем бою:"",
        ""chinese"": ""近战毒伤害:"",
        ""slovak"": ""Jedovaté poškodenie na blízko:""
      },
      {
        ""identifier"": ""MeleeEnergyDamage"",
        ""english"": ""Melee energy damage:"",
        ""russian"": ""Энергетический урон в ближнем бою:"",
        ""chinese"": ""近战毒伤害:"",
        ""slovak"": ""Energetické poškodenie na blízko:""
      },
      {
        ""identifier"": ""RangedPhysicalDamage"",
        ""english"": ""Ranged physical damage:"",
        ""russian"": ""Физический урон дальнего боя:"",
        ""chinese"": ""远程物理伤害:"",
        ""slovak"": ""Fyzické poškodenie na diaľku:""
      },
      {
        ""identifier"": ""RangedFireDamage"",
        ""english"": ""Ranged fire damage:"",
        ""russian"": ""Урон огнем дальнего боя:"",
        ""chinese"": ""远程火焰伤害:"",
        ""slovak"": ""Ohnivé poškodenie na diaľku:""
      },
      {
        ""identifier"": ""RangedColdDamage"",
        ""english"": ""Ranged cold damage:"",
        ""russian"": ""Дальний урон холодом:"",
        ""chinese"": ""远程寒冷伤害:"",
        ""slovak"": ""Ľadové poškodenie na diaľku:""
      },
      {
        ""identifier"": ""RangedPoisonDamage"",
        ""english"": ""Ranged poison damage:"",
        ""russian"": ""Урон ядом дальнего боя:"",
        ""chinese"": ""远程毒药伤害:"",
        ""slovak"": ""Jedovaté poškodenie na diaľku:""
      },
      {
        ""identifier"": ""RangedEnergyDamage"",
        ""english"": ""Ranged energy damage:"",
        ""russian"": ""Энергетический урон дальнего боя:"",
        ""chinese"": ""远程能量伤害:"",
        ""slovak"": ""Energetické poškodenie na diaľku:""
      },
      {
        ""identifier"": ""PsiDamage"",
        ""english"": ""Psychic damage:"",
        ""russian"": ""Психический урон:"",
        ""chinese"": ""精神伤害:"",
        ""slovak"": ""Psychické poškodenie:""
      },
      {
        ""identifier"": ""PsiProtection"",
        ""english"": ""Psychic protection:"",
        ""russian"": ""Психическая защита:"",
        ""chinese"": ""心灵保护:"",
        ""slovak"": ""Psychická ochrana:""
      },
      {
        ""identifier"": ""HitChance"",
        ""english"": ""Attack speed:"",
        ""russian"": ""Шанс попадания:"",
        ""chinese"": ""命中机会:"",
        ""slovak"": ""Šanca na zásah:""
      },
      {
        ""identifier"": ""Dodge"",
        ""english"": ""Dodge:"",
        ""russian"": ""Уклонение:"",
        ""chinese"": ""闪避:"",
        ""slovak"": ""Uhnutie:""
      },
      {
        ""identifier"": ""Dodged"",
        ""english"": ""Dodge"",
        ""russian"": ""Уклонение"",
        ""chinese"": ""闪避"",
        ""slovak"": ""Uhnutie""
      },
      {
        ""identifier"": ""Missed"",
        ""english"": ""Miss"",
        ""russian"": ""пропущенная"",
        ""chinese"": ""错过目标"",
        ""slovak"": ""Netrafil""
      },
      {
        ""identifier"": ""Resisted"",
        ""english"": ""Resisted"",
        ""russian"": ""Сопротивлялся"",
        ""chinese"": ""抵抗了效果"",
        ""slovak"": ""Odolané""
      },
      {
        ""identifier"": ""CounterAttack"",
        ""english"": ""Counter attack!"",
        ""russian"": ""Контратака!"",
        ""chinese"": ""反击！"",
        ""slovak"": ""Protiútok!""
      },
      {
        ""identifier"": ""CounterChance"",
        ""english"": ""Chance to counter attack:"",
        ""russian"": ""Шанс контратаки:"",
        ""chinese"": ""反击的机会:"",
        ""slovak"": ""Šanca na protiútok:""
      },
      {
        ""identifier"": ""Resistance"",
        ""english"": ""Resistance:"",
        ""russian"": ""Устойчивость:"",
        ""chinese"": ""弹力:"",
        ""slovak"": ""Odolnosť:""
      },
      {
        ""identifier"": ""Penetration"",
        ""english"": ""Penetration:"",
        ""russian"": ""Проникновение:"",
        ""chinese"": ""渗透:"",
        ""slovak"": ""Penetrácia:""
      },
      {
        ""identifier"": ""EnergyCapacity"",
        ""english"": ""Energy capacity:"",
        ""russian"": ""Энергетическая мощность:"",
        ""chinese"": ""能量容量:"",
        ""slovak"": ""Energetická kapacita:""
      },
      {
        ""identifier"": ""InventorySlots"",
        ""english"": ""Inventory slots:"",
        ""russian"": ""Слоты инвентаря:"",
        ""chinese"": ""额外的库存槽位:"",
        ""slovak"": ""Miesta v inventári:""
      },
      {
        ""identifier"": ""VisibilityRadius"",
        ""english"": ""Viewable range:"",
        ""russian"": ""Область видимости:"",
        ""chinese"": ""可视范围:"",
        ""slovak"": ""Oblasť viditeľnosti:""
      },
      {
        ""identifier"": ""ExplorationRadius"",
        ""english"": ""Exploration radius:"",
        ""russian"": ""Объем разведки:"",
        ""chinese"": ""探索范围:"",
        ""slovak"": ""Rozsah prieskumu:""
      },
      {
        ""identifier"": ""PickupRadius"",
        ""english"": ""Pickup radius:"",
        ""russian"": ""Объем сбора:"",
        ""chinese"": ""征集范围:"",
        ""slovak"": ""Rozsah zbieru:""
      },
      {
        ""identifier"": ""ProductionSpeed"",
        ""english"": ""Production speed:"",
        ""russian"": ""Скорость производства:"",
        ""chinese"": ""生产速度:"",
        ""slovak"": ""Rýchlosť výroby:""
      },
      {
        ""identifier"": ""MaterialCost"",
        ""english"": ""Material cost:"",
        ""russian"": ""Расход материала:"",
        ""chinese"": ""材料消耗:"",
        ""slovak"": ""Spotreba materiálu:""
      },
      {
        ""identifier"": ""OutcomeRate"",
        ""english"": ""Production quantity:"",
        ""russian"": ""Количество продукции:"",
        ""chinese"": ""生产数量:"",
        ""slovak"": ""Výrobné množstvo:""
      },
      {
        ""identifier"": ""ExecutionFailed"",
        ""english"": ""Execution failed"",
        ""russian"": ""Выполнение не удалось"",
        ""chinese"": ""执行失败"",
        ""slovak"": ""Vykonanie zlyhalo""
      },
      {
        ""identifier"": ""OxygenNotRequired"",
        ""english"": ""You don't need an oxygen tank in this area."",
        ""russian"": ""Вам не нужен кислородный баллон в этой области."",
        ""chinese"": ""在这个区域你不需要氧气瓶。"",
        ""slovak"": ""V tejto oblasti nepotrebujete kyslíkovú nádrž.""
      },
      {
        ""identifier"": ""SplitFailed"",
        ""english"": ""You can't split this item at its current quantity."",
        ""russian"": ""Вы не можете разделить этот товар в его текущем количестве."",
        ""chinese"": ""您无法按当前数量拆分此商品。"",
        ""slovak"": ""Túto vec nemôžete rozdeliť v aktuálnom množstve.""
      },
      {
        ""identifier"": ""FabricatorNotEquipped"",
        ""english"": ""Fabricator is not equipped!"",
        ""russian"": ""Производитель не оборудован!"",
        ""chinese"": ""制造装置未配备！"",
        ""slovak"": ""Výrobník nemáte vo vybavení!""
      },
      {
        ""identifier"": ""FAB-1Desc"",
        ""english"": ""The Fabricator: a handheld marvel, seamlessly transforming raw resources into any item imaginable, from advanced weaponry to essential tools, unlocking limitless possibilities."",
        ""russian"": ""Фабрикатор: портативное чудо, плавно превращающее сырые ресурсы в любые предметы, которые только можно вообразить, от передового оружия до необходимых инструментов, открывая безграничные возможности."",
        ""chinese"": ""制造者：一种手持式奇迹，可以将原始资源无缝地转化为任何可以想象的物品，从先进武器到基本工具，释放无限的可能性。"",
        ""slovak"": ""Výrobník: ručný zázrak, ktorý plynule premieňa surové zdroje na akýkoľvek predmet, ktorý si dokážete predstaviť, od pokročilých zbraní až po základné nástroje, odomykajúci neobmedzené možnosti.""
      },
      {
        ""identifier"": ""Research"",
        ""english"": ""Research"",
        ""russian"": ""Исследовать"",
        ""chinese"": ""研究"",
        ""slovak"": ""Výskum""
      },
      {
        ""identifier"": ""ResearchPoint"",
        ""english"": ""Research point"",
        ""russian"": ""Точка исследования"",
        ""chinese"": ""研究点"",
        ""slovak"": ""Výskumný bod""
      },
      {
        ""identifier"": ""ResearchScienceProjects"",
        ""english"": ""Complete a research 'Science projects'"",
        ""russian"": ""Завершить исследование «Научные проекты»"",
        ""chinese"": ""完成一项研究“科学项目”"",
        ""slovak"": ""Dokončite výskum „Vedecké projekty“""
      },
      {
        ""identifier"": ""ResearchScienceProjectsDesc"",
        ""english"": ""Place a <color=yellow>Research device</color> in your base to generate research points. Then complete <color=yellow>Science Project</color> research."",
        ""russian"": ""Разместите <color=yellow>Исследовательское устройство</color> на своей базе, чтобы получать очки исследования. Затем завершите исследование <color=yellow>Научного проекта</color>."",
        ""chinese"": ""在你的基地放置一个<color=yellow>研究装置</color>来生成研究点。然后完成<color=yellow>科学项目</color>研究。"",
        ""slovak"": ""Umiestnite <color=yellow>Výskumné zariadenie</color> do svojej základne a generujte výskumné body. Potom dokončite výskum <color=yellow>Vedeckého projektu</color>.""
      },
      {
        ""identifier"": ""ScienceProjects"",
        ""english"": ""Science projects"",
        ""russian"": ""Научные проекты"",
        ""chinese"": ""科学项目"",
        ""slovak"": ""Vedecké projekty""
      },
      {
        ""identifier"": ""ScienceProjectsDesc"",
        ""english"": ""Enables the research of multiple categories."",
        ""russian"": ""Позволяет исследовать несколько категорий."",
        ""chinese"": ""该项目允许进行多个类别的研究。"",
        ""slovak"": ""Umožňuje výskum viacerých kategórií.""
      },
      {
        ""identifier"": ""Rewards"",
        ""english"": ""Rewards:"",
        ""russian"": ""Награды:"",
        ""chinese"": ""奖励："",
        ""slovak"": ""Odmeny:""
      },
      {
        ""identifier"": ""Requirements"",
        ""english"": ""Requirements:"",
        ""russian"": ""Требования:"",
        ""chinese"": ""要求："",
        ""slovak"": ""Požiadavky:""
      },
      {
        ""identifier"": ""SteamPower"",
        ""english"": ""Steam power"",
        ""russian"": ""Сила пара"",
        ""chinese"": ""蒸汽动力"",
        ""slovak"": ""Parný pohon""
      },
      {
        ""identifier"": ""SteamPowerDesc"",
        ""english"": ""Unlocks the usage of steam as a resource together with steam powered buildings."",
        ""russian"": ""Открывает возможность использования пара в качестве ресурса вместе со зданиями, работающими на паре."",
        ""chinese"": ""解锁蒸汽作为资源以及蒸汽动力建筑的使用。"",
        ""slovak"": ""Odomkne využitie pary ako zdroja spolu s budovami poháňanými parou.""
      },
      {
        ""identifier"": ""BasicAlchemy"",
        ""english"": ""Basic alchemy"",
        ""russian"": ""Базовая алхимия"",
        ""chinese"": ""基础炼金术"",
        ""slovak"": ""Základná alchýmia""
      },
      {
        ""identifier"": ""BasicAlchemyDesc"",
        ""english"": ""Introduces the concept of combining materials to create potions and chemicals with various effects."",
        ""russian"": ""Представляет концепцию объединения материалов для создания зелий и химикатов с различными эффектами."",
        ""chinese"": ""这项研究引入了结合材料来制造具有各种效果的药水和化学品的概念。"",
        ""slovak"": ""Predstavuje koncept kombinovania materiálov na vytváranie elixírov a chemikálií s rôznymi účinkami.""
      },
      {
        ""identifier"": ""AllProduction"",
        ""english"": ""All production"",
        ""russian"": ""Вся продукция"",
        ""chinese"": ""全部生产"",
        ""slovak"": ""Celá výroba""
      },
      {
        ""identifier"": ""ByType"",
        ""english"": ""Type"",
        ""russian"": ""Тип"",
        ""chinese"": ""类型"",
        ""slovak"": ""Typ""
      },
      {
        ""identifier"": ""Quantity"",
        ""english"": ""Quantity :"",
        ""russian"": ""Количество :"",
        ""chinese"": ""数量 ："",
        ""slovak"": ""Množstvo :""
      },
      {
        ""identifier"": ""FishMeat"",
        ""english"": ""Fish meat"",
        ""russian"": ""Рыбное мясо"",
        ""chinese"": ""鱼肉"",
        ""slovak"": ""Rybie mäso""
      },
      {
        ""identifier"": ""FishMeatDesc"",
        ""english"": ""Healthy protein resource and also can be a recipe ingredient."",
        ""russian"": ""Полезный белковый ресурс, а также может быть ингредиентом рецепта."",
        ""chinese"": ""鱼肉是一种有用的蛋白质资源，也可以作为食谱成分。"",
        ""slovak"": ""Zdravý zdroj bielkovín a tiež môže byť zložkou receptu.""
      },
      {
        ""identifier"": ""AnimalMeat"",
        ""english"": ""Animal meat"",
        ""russian"": ""Мясо животных"",
        ""chinese"": ""动物肉"",
        ""slovak"": ""Zvieracie mäso""
      },
      {
        ""identifier"": ""AnimalMeatDesc"",
        ""english"": ""Food resource acquired from animals that requires further processing."",
        ""russian"": ""Пищевой ресурс, полученный от животных и требующий дальнейшей переработки."",
        ""chinese"": ""这是从动物身上获得的食物资源，需要进一步加工。"",
        ""slovak"": ""Potravinový zdroj získaný zo zvierat, ktorý si vyžaduje ďalšie spracovanie.""
      },
      {
        ""identifier"": ""SmallFish"",
        ""english"": ""Small fish"",
        ""russian"": ""Маленькая рыба"",
        ""chinese"": ""小鱼"",
        ""slovak"": ""Malá ryba""
      },
      {
        ""identifier"": ""Whale"",
        ""english"": ""Whale"",
        ""russian"": ""Кит"",
        ""chinese"": ""鲸"",
        ""slovak"": ""Veľryba""
      },
      {
        ""identifier"": ""Kuleoma"",
        ""english"": ""Kuleoma"",
        ""russian"": ""Кулеома"",
        ""chinese"": ""Kuleoma"",
        ""slovak"": ""Kuleoma""
      },
      {
        ""identifier"": ""SeaTurtle"",
        ""english"": ""Sea turtle"",
        ""russian"": ""Морская черепаха"",
        ""chinese"": ""海龟"",
        ""slovak"": ""Morská korytnačka""
      },
      {
        ""identifier"": ""Shark"",
        ""english"": ""Shark"",
        ""russian"": ""Акула"",
        ""chinese"": ""鲨鱼"",
        ""slovak"": ""Žralok""
      },
      {
        ""identifier"": ""Octopus"",
        ""english"": ""Octopus"",
        ""russian"": ""Осьминог"",
        ""chinese"": ""章鱼"",
        ""slovak"": ""Chobotnica""
      },
      {
        ""identifier"": ""SilicaSand"",
        ""english"": ""Silica sand"",
        ""russian"": ""Кварцевый песок"",
        ""chinese"": ""硅砂"",
        ""slovak"": ""Kremičitý piesok""
      },
      {
        ""identifier"": ""Clay"",
        ""english"": ""Clay"",
        ""russian"": ""Глина"",
        ""chinese"": ""黏土"",
        ""slovak"": ""Hlina""
      },
      {
        ""identifier"": ""Limestone"",
        ""english"": ""Limestone"",
        ""russian"": ""Известняк"",
        ""chinese"": ""石灰石"",
        ""slovak"": ""Vápenec""
      },
      {
        ""identifier"": ""CopperOre"",
        ""english"": ""Copper ore"",
        ""russian"": ""Медная руда"",
        ""chinese"": ""铜矿"",
        ""slovak"": ""Medená ruda""
      },
      {
        ""identifier"": ""Stone"",
        ""english"": ""Stone"",
        ""russian"": ""Камень"",
        ""chinese"": ""石头"",
        ""slovak"": ""Kameň""
      },
      {
        ""identifier"": ""GoldOre"",
        ""english"": ""Gold ore"",
        ""russian"": ""Золотая руда"",
        ""chinese"": ""金矿"",
        ""slovak"": ""Zlatá ruda""
      },
      {
        ""identifier"": ""SilverOre"",
        ""english"": ""Silver ore"",
        ""russian"": ""Серебряная руда"",
        ""chinese"": ""银矿石"",
        ""slovak"": ""Strieborná ruda""
      },
      {
        ""identifier"": ""RedHorn"",
        ""english"": ""Red horn"",
        ""russian"": ""Красный рог"",
        ""chinese"": ""红角"",
        ""slovak"": ""Červený roháč""
      },
      {
        ""identifier"": ""Bantir"",
        ""english"": ""Bantir"",
        ""russian"": ""Бантир"",
        ""chinese"": ""Bantir"",
        ""slovak"": ""Bantir""
      },
      {
        ""identifier"": ""AnimalSkin"",
        ""english"": ""Animal skin"",
        ""russian"": ""Кожа животного"",
        ""chinese"": ""动物皮"",
        ""slovak"": ""Zvieracia koža""
      },
      {
        ""identifier"": ""Milk"",
        ""english"": ""Milk"",
        ""russian"": ""Молоко"",
        ""chinese"": ""牛奶"",
        ""slovak"": ""Mlieko""
      },
      {
        ""identifier"": ""Sulfur"",
        ""english"": ""Sulfur"",
        ""russian"": ""Cера"",
        ""chinese"": ""硫"",
        ""slovak"": ""Síra""
      },
      {
        ""identifier"": ""Saltpeter"",
        ""english"": ""Potassium nitrate"",
        ""russian"": ""Азотнокислый калий"",
        ""chinese"": ""硝酸钾"",
        ""slovak"": ""Dusičnan draselný""
      },
      {
        ""identifier"": ""DeleteData"",
        ""english"": ""Delete data?"",
        ""russian"": ""Удалить данные?"",
        ""chinese"": ""删除数据？"",
        ""slovak"": ""Odstrániť údaje?""
      },
      {
        ""identifier"": ""DeleteDataDesc"",
        ""english"": ""All saved progress will be deleted permantnely."",
        ""russian"": ""Эти игровые данные будут удалены навсегда."",
        ""chinese"": ""该游戏数据将被永久删除。"",
        ""slovak"": ""Tieto herné údaje budú natrvalo vymazané.""
      },
      {
        ""identifier"": ""RemainingQuantity"",
        ""english"": ""Remaining quantity:"",
        ""russian"": ""Оставшееся количество:"",
        ""chinese"": ""剩余数量："",
        ""slovak"": ""Zostávajúce množstvo:""
      },
      {
        ""identifier"": ""FirstEventMessage"",
        ""english"": ""This planet looks habitable and luckily got atmosphere with oxygen. All items that I was able to save from the spaceship are now in my inventory."",
        ""russian"": ""Эта планета выглядит обитаемой и, к счастью, имеет атмосферу с кислородом. Все предметы, которые мне удалось сохранить с космического корабля, теперь находятся у меня в инвентаре."",
        ""chinese"": ""这颗行星看起来适合居住，并且有含有氧气的大气层。我能够从宇宙飞船中保存的所有物品现在都在我的库存中。"",
        ""slovak"": ""Táto planéta vyzerá obývateľná a našťastie má atmosféru s kyslíkom. Všetky predmety, ktoré sa mi podarilo zachrániť z vesmírnej lode sú teraz v mojom inventári.""
      },
      {
        ""identifier"": ""MaterialDiscoveryMessage"",
        ""english"": ""You have discovered"",
        ""russian"": ""Вы обнаружили"",
        ""chinese"": ""您发现了"",
        ""slovak"": ""Objavili ste""
      },
      {
        ""identifier"": ""Discovery"",
        ""english"": ""Discovery"",
        ""russian"": ""Открытие"",
        ""chinese"": ""发现"",
        ""slovak"": ""Objavovanie""
      },
      {
        ""identifier"": ""Collecting"",
        ""english"": ""Collecting"",
        ""russian"": ""Сбор"",
        ""chinese"": ""搜集"",
        ""slovak"": ""Zbieranie""
      },
      {
        ""identifier"": ""All"",
        ""english"": ""All"",
        ""russian"": ""Все"",
        ""chinese"": ""所有"",
        ""slovak"": ""Všetky""
      },
      {
        ""identifier"": ""Caves"",
        ""english"": ""Caves"",
        ""russian"": ""Пещеры"",
        ""chinese"": ""洞穴"",
        ""slovak"": ""Jaskyne""
      },
      {
        ""identifier"": ""VolcanicCave"",
        ""english"": ""Volcanic cave"",
        ""russian"": ""Вулканическая пещера"",
        ""chinese"": ""火山洞穴"",
        ""slovak"": ""Vulkanická jaskyňa""
      },
      {
        ""identifier"": ""IceCave"",
        ""english"": ""Ice cave"",
        ""russian"": ""Ледяные пещера"",
        ""chinese"": ""冰洞"",
        ""slovak"": ""Ľadová jaskyňa""
      },
      {
        ""identifier"": ""HiveNest"",
        ""english"": ""Hive nest"",
        ""russian"": ""Ульевые гнездо"",
        ""chinese"": ""蜂巢"",
        ""slovak"": ""Úľové hniezdo""
      },
      {
        ""identifier"": ""CyberHideout"",
        ""english"": ""Cyber hideout"",
        ""russian"": ""Кибер-убежище"",
        ""chinese"": ""网络藏身处"",
        ""slovak"": ""Kybernetický úkryt""
      },
      {
        ""identifier"": ""Missions"",
        ""english"": ""Missions"",
        ""russian"": ""Миссии"",
        ""chinese"": ""使命"",
        ""slovak"": ""Misie""
      },
      {
        ""identifier"": ""AlienBase"",
        ""english"": ""Alien base"",
        ""russian"": ""База пришельцев"",
        ""chinese"": ""外星人基地"",
        ""slovak"": ""Mimozemská základňa""
      },
      {
        ""identifier"": ""WormTunnels"",
        ""english"": ""Worm tunnel"",
        ""russian"": ""Червячные туннели"",
        ""chinese"": ""蠕虫隧道"",
        ""slovak"": ""Červové tunely""
      },
      {
        ""identifier"": ""Shipwreck"",
        ""english"": ""Shipwreck"",
        ""russian"": ""Кораблекрушение"",
        ""chinese"": ""海难"",
        ""slovak"": ""Stroskotaná loď""
      },
      {
        ""identifier"": ""MysticTemple"",
        ""english"": ""Mystic temple"",
        ""russian"": ""Мистический храм"",
        ""chinese"": ""神秘寺庙"",
        ""slovak"": ""Mystický chrám""
      },
      {
        ""identifier"": ""Monsters"",
        ""english"": ""Monsters"",
        ""russian"": ""Монстры"",
        ""chinese"": ""怪物"",
        ""slovak"": ""Stvorenia""
      },
      {
        ""identifier"": ""XenoSpider"",
        ""english"": ""Xeno-Spider"",
        ""russian"": ""Ксено-паук"",
        ""chinese"": ""异种蜘蛛"",
        ""slovak"": ""Xeno-pavúk""
      },
      {
        ""identifier"": ""SporeBehemoth"",
        ""english"": ""Spore behemoth"",
        ""russian"": ""Споровый бегемот"",
        ""chinese"": ""孢子巨兽"",
        ""slovak"": ""Spórový behemot""
      },
      {
        ""identifier"": ""ElectroBeast"",
        ""english"": ""Electro-Beast"",
        ""russian"": ""Электрический-монстр"",
        ""chinese"": ""电兽"",
        ""slovak"": ""Elektrický netvor""
      },
      {
        ""identifier"": ""VoidReaper"",
        ""english"": ""Void reaper"",
        ""russian"": ""Пустотный призрак"",
        ""chinese"": ""虚空幽灵"",
        ""slovak"": ""Mátoha prázdnoty""
      },
      {
        ""identifier"": ""Resources"",
        ""english"": ""Resources"",
        ""russian"": ""Ресурсы"",
        ""chinese"": ""资源"",
        ""slovak"": ""Suroviny""
      },
      {
        ""identifier"": ""Anomaly"",
        ""english"": ""Anomalies"",
        ""russian"": ""Аномалия"",
        ""chinese"": ""不规则"",
        ""slovak"": ""Anomália""
      },
      {
        ""identifier"": ""MysteryDevice"",
        ""english"": ""Mystery device"",
        ""russian"": ""Таинственное устройство"",
        ""chinese"": ""神秘装置"",
        ""slovak"": ""Tajomné zariadenie""
      },
      {
        ""identifier"": ""Level"",
        ""english"": ""Level:"",
        ""russian"": ""Уровень:"",
        ""chinese"": ""等级："",
        ""slovak"": ""Úroveň:""
      },
      {
        ""identifier"": ""Size"",
        ""english"": ""Size:"",
        ""russian"": ""Размер:"",
        ""chinese"": ""大小："",
        ""slovak"": ""Veľkosť:""
      },
      {
        ""identifier"": ""Large"",
        ""english"": ""Large"",
        ""russian"": ""Большой"",
        ""chinese"": ""大型"",
        ""slovak"": ""Veľká/ý""
      },
      {
        ""identifier"": ""Medium"",
        ""english"": ""Medium"",
        ""russian"": ""Средний"",
        ""chinese"": ""普通大小"",
        ""slovak"": ""Priemerná/ý""
      },
      {
        ""identifier"": ""Small"",
        ""english"": ""Small"",
        ""russian"": ""Средний"",
        ""chinese"": ""小型"",
        ""slovak"": ""Malá/ý""
      },
      {
        ""identifier"": ""Combat"",
        ""english"": ""Combat"",
        ""russian"": ""Бой"",
        ""chinese"": ""战斗"",
        ""slovak"": ""Boj""
      },
      {
        ""identifier"": ""Enter"",
        ""english"": ""Enter"",
        ""russian"": ""Войти"",
        ""chinese"": ""进入"",
        ""slovak"": ""Vstúpiť""
      },
      {
        ""identifier"": ""Cancel"",
        ""english"": ""Cancel"",
        ""russian"": ""Отмена"",
        ""chinese"": ""取消"",
        ""slovak"": ""Zrušiť""
      },
      {
        ""identifier"": ""Continue"",
        ""english"": ""Continue"",
        ""russian"": ""Продолжать"",
        ""chinese"": ""继续"",
        ""slovak"": ""Pokračovať""
      },
      {
        ""identifier"": ""Leave"",
        ""english"": ""Leave"",
        ""russian"": ""Покинуть"",
        ""chinese"": ""离开"",
        ""slovak"": ""Odísť""
      },
      {
        ""identifier"": ""Melee"",
        ""english"": ""Melee"",
        ""russian"": ""Ближний бой"",
        ""chinese"": ""近战能力"",
        ""slovak"": ""Schopnosť zblízka""
      },
      {
        ""identifier"": ""Ranged"",
        ""english"": ""Ranged"",
        ""russian"": ""Дальний бой"",
        ""chinese"": ""远程能力"",
        ""slovak"": ""Schopnosť na diaľku""
      },
      {
        ""identifier"": ""Psi"",
        ""english"": ""Psionic"",
        ""russian"": ""Псионический бой"",
        ""chinese"": ""灵能能力"",
        ""slovak"": ""Psionická schopnosť""
      },
      {
        ""identifier"": ""CAS-901"",
        ""english"": ""CAS-901"",
        ""russian"": ""КАС-901"",
        ""chinese"": ""CAS-901"",
        ""slovak"": ""CAS-901""
      },
      {
        ""identifier"": ""CAS-101"",
        ""english"": ""CAS-101"",
        ""russian"": ""КАС-101"",
        ""chinese"": ""CAS-101"",
        ""slovak"": ""CAS-101""
      },
      {
        ""identifier"": ""FAB-1"",
        ""english"": ""FAB-1"",
        ""russian"": ""ФAБ-1"",
        ""chinese"": ""FAB-1"",
        ""slovak"": ""FAB-1""
      },
      {
        ""identifier"": ""EF-10"",
        ""english"": ""EF-10"",
        ""russian"": ""ЭФ-10"",
        ""chinese"": ""EF-10"",
        ""slovak"": ""EF-10""
      },
      {
        ""identifier"": ""PSP-1"",
        ""english"": ""PSP-1"",
        ""russian"": ""ПСП-1"",
        ""chinese"": ""PSP-1"",
        ""slovak"": ""PSP-1""
      },
      {
        ""identifier"": ""StunBaton"",
        ""english"": ""Stun baton"",
        ""russian"": ""Электрошоковая дубинка"",
        ""chinese"": ""电击棒"",
        ""slovak"": ""Elektro-šokový obušok""
      },
      {
        ""identifier"": ""SpiritCrystal"",
        ""english"": ""Spiritual crystal"",
        ""russian"": ""Духовный кристалл"",
        ""chinese"": ""灵性水晶"",
        ""slovak"": ""Spirituálny kryštál""
      },
      {
        ""identifier"": ""Slash"",
        ""english"": ""Slash"",
        ""russian"": ""Режущий удар"",
        ""chinese"": ""斩击"",
        ""slovak"": ""Sečná rana""
      },
      {
        ""identifier"": ""Stab"",
        ""english"": ""Stab"",
        ""russian"": ""Колотый удар"",
        ""chinese"": ""刺击"",
        ""slovak"": ""Bodnutie""
      },
      {
        ""identifier"": ""AimedShot"",
        ""english"": ""Aimed shot"",
        ""russian"": ""Прицельный выстрел"",
        ""chinese"": ""精准射击"",
        ""slovak"": ""Mierený výstrel""
      },
      {
        ""identifier"": ""BurstShotPistol"",
        ""english"": ""Burst shot"",
        ""russian"": ""Cтрельба очередями"",
        ""chinese"": ""点射"",
        ""slovak"": ""Salva""
      },
      {
        ""identifier"": ""Choke"",
        ""english"": ""Choke"",
        ""russian"": ""Удушение"",
        ""chinese"": ""绞杀"",
        ""slovak"": ""Škrtenie""
      },
      {
        ""identifier"": ""Terrify"",
        ""english"": ""Terrify"",
        ""russian"": ""Бояться"",
        ""chinese"": ""恐惧"",
        ""slovak"": ""Vystrašiť""
      },
      {
        ""identifier"": ""MindControl"",
        ""english"": ""Mind control"",
        ""russian"": ""Контроль над разумом"",
        ""chinese"": ""精神控制"",
        ""slovak"": ""Ovládnutie mysle""
      },
      {
        ""identifier"": ""Swing"",
        ""english"": ""Swing"",
        ""russian"": ""Взмах"",
        ""chinese"": ""摆动"",
        ""slovak"": ""Zahnanie""
      },
      {
        ""identifier"": ""Smash"",
        ""english"": ""Smash"",
        ""russian"": ""Сокрушительный удар"",
        ""chinese"": ""毁灭性的打击"",
        ""slovak"": ""Drvivá rana""
      },
      {
        ""identifier"": ""Add Friend"",
        ""english"": ""Add friend"",
        ""russian"": ""Добавить друга"",
        ""chinese"": ""添加朋友"",
        ""slovak"": ""Pridať priateľa""
      },
      {
        ""identifier"": ""Friend"",
        ""english"": ""Friend"",
        ""russian"": ""Друг"",
        ""chinese"": ""朋友"",
        ""slovak"": ""Priateľ""
       },
       {
         ""identifier"": ""Friend Request"",
         ""english"": ""Friend request"",
         ""russian"": ""Запрос на дружбу"",
         ""chinese"": ""好友请求"",
         ""slovak"": ""Žiadosť o priateľstvo""
       },
       {
         ""identifier"": ""Friend Requests"",
        ""english"": ""Friend requests"",
        ""russian"": ""Запросы на дружбу"",
        ""chinese"": ""好友请求"",
        ""slovak"": ""Žiadosti o priateľstvo""
       },
       {
         ""identifier"": ""Leave Group"",
         ""english"": ""Leave group"",
         ""russian"": ""Покинуть группу"",
         ""chinese"": ""离开组"",
         ""slovak"": ""Opustiť skupinu""
       },
       {
         ""identifier"": ""Remove From Group"",
         ""english"": ""Remove from group"",
         ""russian"": ""Удалить из группы"",
         ""chinese"": ""从组中删除"",
         ""slovak"": ""Odstrániť zo skupiny""
        },
        {
            ""identifier"": ""Remove From Friends"",
            ""english"": ""Remove from friends"",
            ""russian"": ""Удалить из друзей"",
            ""chinese"": ""从好友中删除"",
            ""slovak"": ""Odstrániť zo zoznamu priateľov""
        },
        {
            ""identifier"": ""Add group member"",
            ""english"": ""Add group member"",
            ""russian"": ""Добавить участника группы"",
            ""chinese"": ""添加组成员"",
            ""slovak"": ""Pridať člena skupiny""
        },
        {
            ""identifier"": ""Add to group"",
            ""english"": ""Add to group"",
            ""russian"": ""Добавить в группу"",
            ""chinese"": ""添加到组"",
            ""slovak"": ""Pridať do skupiny""
        },
        
      {
        ""identifier"": ""Ignite"",
        ""english"": ""Ignite"",
        ""russian"": ""Вспышка"",
        ""chinese"": ""烧伤"",
        ""slovak"": ""Vzplanutie""
      },
      {
        ""identifier"": ""MagmaTouch"",
        ""english"": ""Magma touch"",
        ""russian"": ""Прикосновение магмы"",
        ""chinese"": ""岩浆触摸"",
        ""slovak"": ""Dotyk magmy""
      },
      {
        ""identifier"": ""CombatLogMessage"",
        ""english"": ""<color=#63ECFF>{activeCharName}</color> uses <color=yellow>{abilityName}</color> and hits enemies for <color=yellow>{damage} damage</color>."",
        ""russian"": ""<color=#63ECFF>{activeCharName}</color> использует <color=yellow>{abilityName}</color> и наносит врагам <color=yellow>{damage} единиц урона</color>."",
        ""chinese"": ""<color=#63ECFF>{activeCharName}</color> 使用 <color=yellow>{abilityName}</color> 并对敌人造成 <color=yellow>{damage} 点伤害</color>."",
        ""slovak"": ""<color=#63ECFF>{activeCharName}</color> použil/a <color=yellow>{abilityName}</color> a trafil/a nepriateľa za <color=yellow>{damage} rany</color>.""       
      },
      {
        ""identifier"": ""DoTMessage"",
        ""english"": ""<color=#63ECFF>{activeCharName}</color> received <color=yellow>{damage} damage</color> from <color=yellow>{statusEffectName}</color>."",
        ""russian"": ""<color=#63ECFF>{activeCharName}</color> получает <color=yellow>{damage} урона от эффекта</color> from <color=yellow>{statusEffectName}</color>."",
        ""chinese"": ""<color=#63ECFF>{activeCharName}</color> 因 <color=yellow>{statusEffectName}</color> 的效果而受到 <color=yellow>{damage} 点伤害</color>."",
        ""slovak"": ""<color=#63ECFF>{activeCharName}</color> dostal/a <color=yellow>{damage} rany</color> z efektu <color=yellow>{statusEffectName}</color>.""       
      },
      {
        ""identifier"": ""Wallet"",
        ""english"": ""Wallet"",
        ""russian"": ""Кошелек"",
        ""chinese"": ""钱包"",
        ""slovak"": ""Peňaženka""
      },
      {
        ""identifier"": ""GalacticCredits"",
        ""english"": ""Galactic credits"",
        ""russian"": ""Галактические кредиты"",
        ""chinese"": ""银河币"",
        ""slovak"": ""Galaktické kredity""
      },
      {
        ""identifier"": ""CurrencyRequest"",
        ""english"": ""Please enter the recipient and the amount you are requesting."",
        ""russian"": ""Пожалуйста, укажите получателя и сумму, которую вы запрашиваете."",
        ""chinese"": ""请输入收件人和您要请求的金额。"",
        ""slovak"": ""Zadajte príjemcu a sumu, ktorú požadujete.""
      },
      {
        ""identifier"": ""CurrencySend"",
        ""english"": ""Please enter the recipient and the amount you want to send."",
        ""russian"": ""Пожалуйста, введите получателя и сумму, которую вы хотите отправить."",
        ""chinese"": ""请输入收件人和您要发送的金额。"",
        ""slovak"": ""Zadajte príjemcu a sumu, ktorú chcete poslať.""
      },
      {
        ""identifier"": ""FireEatingLeviathan"",
        ""english"": ""Fire-Eating Leviathan"",
        ""russian"": ""Гигантский пожиратель огня"",
        ""chinese"": ""噬火利维坦"",
        ""slovak"": ""Obrovský požierač ohňa""
      },
      {
        ""identifier"": ""IceCreep"",
        ""english"": ""Ice stalker"",
        ""russian"": ""Ледяной сталкер"",
        ""chinese"": ""冰影"",
        ""slovak"": ""Ľadová obluda""
      },
      {
        ""identifier"": ""Invisible"",
        ""english"": ""Invisible"",
        ""russian"": ""Невидимый"",
        ""chinese"": ""无形的"",
        ""slovak"": ""Neviditeľný""
      }
    ]
  }
";
    }
}
