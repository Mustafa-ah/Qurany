﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.IO;
namespace quran
{
    class Quran
    {
        public string[] ayat = new string[] { "الم	(1)", "الْحَمْدُ لِلَّـهِ رَبِّ الْعَالَمِينَ ﴿٢﴾",
            "الذين يؤمنون بالغيب ويقيمون الصلاة ومما رزقناهم ينفقون (3)",
        "ذَٰلِكَ الْكِتَابُ لَا رَيْبَ ۛ فِيهِ ۛ هُدًى لِّلْمُتَّقِينَ ﴿2﴾"
        ,
        	 "الم (1)",
	 "ذلك الكتاب لا ريب فيه هدى للمتقين (2)",
	 "الذين يؤمنون بالغيب ويقيمون الصلاة ومما رزقناهم ينفقون (3)",
	 "والذين يؤمنون بما أنزل إليك وما أنزل من قبلك وبالآخرة هم يوقنون (4)",
	 "أولئك على هدى من ربهم وأولئك هم المفلحون (5)",
	 "إن الذين كفروا سواء عليهم أأنذرتهم أم لم تنذرهم لا يؤمنون (6)",
	 "ختم الله على قلوبهم وعلى سمعهم وعلى أبصارهم غشاوة ولهم عذاب عظيم (7)",
	 "ومن الناس من يقول آمنا بالله وباليوم الآخر وما هم بمؤمنين (8)",
	 "يخادعون الله والذين آمنوا وما يخدعون إلا أنفسهم وما يشعرون (9)",
	 "في قلوبهم مرض فزادهم الله مرضا ولهم عذاب أليم بما كانوا يكذبون (10)",
	 "وإذا قيل لهم لا تفسدوا في الأرض قالوا إنما نحن مصلحون (11)",
	 "ألا إنهم هم المفسدون ولكن لا يشعرون (12)",
	 "وإذا قيل لهم آمنوا كما آمن الناس قالوا أنؤمن كما آمن السفهاء ألا إنهم هم السفهاء ولكن لا يعلمون (13)",
	 "وإذا لقوا الذين آمنوا قالوا آمنا وإذا خلوا إلى شياطينهم قالوا إنا معكم إنما نحن مستهزئون (14)",
	 "الله يستهزئ بهم ويمدهم في طغيانهم يعمهون (15)",
	 "أولئك الذين اشتروا الضلالة بالهدى فما ربحت تجارتهم وما كانوا مهتدين (16)",
	 "مثلهم كمثل الذي استوقد نارا فلما أضاءت ما حوله ذهب الله بنورهم وتركهم في ظلمات لا يبصرون (17)",
	 "صم بكم عمي فهم لا يرجعون (18)",
	 "أو كصيب من السماء فيه ظلمات ورعد وبرق يجعلون أصابعهم في آذانهم من الصواعق حذر الموت والله محيط بالكافرين (19)",
	 "يكاد البرق يخطف أبصارهم كلما أضاء لهم مشوا فيه وإذا أظلم عليهم قاموا ولو شاء الله لذهب بسمعهم وأبصارهم إن الله على كل شيء قدير (20)",
	 "يا أيها الناس اعبدوا ربكم الذي خلقكم والذين من قبلكم لعلكم تتقون (21)",
	 "الذي جعل لكم الأرض فراشا والسماء بناء وأنزل من السماء ماء فأخرج به من الثمرات رزقا لكم فلا تجعلوا لله أندادا وأنتم تعلمون (22)",
	 "وإن كنتم في ريب مما نزلنا على عبدنا فأتوا بسورة من مثله وادعوا شهداءكم من دون الله إن كنتم صادقين (23)",
	 "فإن لم تفعلوا ولن تفعلوا فاتقوا النار التي وقودها الناس والحجارة أعدت للكافرين (24)",
	 "وبشر الذين آمنوا وعملوا الصالحات أن لهم جنات تجري من تحتها الأنهار كلما رزقوا منها من ثمرة رزقا قالوا هذا الذي رزقنا من قبل وأتوا به متشابها ولهم فيها أزواج مطهرة وهم فيها خالدون (25)",
	 "إن الله لا يستحيي أن يضرب مثلا ما بعوضة فما فوقها فأما الذين آمنوا فيعلمون أنه الحق من ربهم وأما الذين كفروا فيقولون ماذا أراد الله بهذا مثلا يضل به كثيرا ويهدي به كثيرا وما يضل به إلا الفاسقين (26)",
	 "الذين ينقضون عهد الله من بعد ميثاقه ويقطعون ما أمر الله به أن يوصل ويفسدون في الأرض أولئك هم الخاسرون (27)",
	 "كيف تكفرون بالله وكنتم أمواتا فأحياكم ثم يميتكم ثم يحييكم ثم إليه ترجعون (28)",
	 "هو الذي خلق لكم ما في الأرض جميعا ثم استوى إلى السماء فسواهن سبع سماوات وهو بكل شيء عليم (29)",
	 "وإذ قال ربك للملائكة إني جاعل في الأرض خليفة قالوا أتجعل فيها من يفسد فيها ويسفك الدماء ونحن نسبح بحمدك ونقدس لك قال إني أعلم ما لا تعلمون (30)",
	 "وعلم آدم الأسماء كلها ثم عرضهم على الملائكة فقال أنبئوني بأسماء هؤلاء إن كنتم صادقين (31)",
	 "قالوا سبحانك لا علم لنا إلا ما علمتنا إنك أنت العليم الحكيم (32)",
	 "قال يا آدم أنبئهم بأسمائهم فلما أنبأهم بأسمائهم قال ألم أقل لكم إني أعلم غيب السماوات والأرض وأعلم ما تبدون وما كنتم تكتمون (33)",
	 "وإذ قلنا للملائكة اسجدوا لآدم فسجدوا إلا إبليس أبى واستكبر وكان من الكافرين (34)",
	 "وقلنا يا آدم اسكن أنت وزوجك الجنة وكلا منها رغدا حيث شئتما ولا تقربا هذه الشجرة فتكونا من الظالمين (35)",
	 "فأزلهما الشيطان عنها فأخرجهما مما كانا فيه وقلنا اهبطوا بعضكم لبعض عدو ولكم في الأرض مستقر ومتاع إلى حين (36)",
	 "فتلقى آدم من ربه كلمات فتاب عليه إنه هو التواب الرحيم (37)",
	 "قلنا اهبطوا منها جميعا فإما يأتينكم مني هدى فمن تبع هداي فلا خوف عليهم ولا هم يحزنون (38)",
	 "والذين كفروا وكذبوا بآياتنا أولئك أصحاب النار هم فيها خالدون (39)",
	 "يا بني إسرائيل اذكروا نعمتي التي أنعمت عليكم وأوفوا بعهدي أوف بعهدكم وإياي فارهبون (40)",
	 "وآمنوا بما أنزلت مصدقا لما معكم ولا تكونوا أول كافر به ولا تشتروا بآياتي ثمنا قليلا وإياي فاتقون (41)",
	 "ولا تلبسوا الحق بالباطل وتكتموا الحق وأنتم تعلمون (42)",
	 "وأقيموا الصلاة وآتوا الزكاة واركعوا مع الراكعين (43)",
	 "أتأمرون الناس بالبر وتنسون أنفسكم وأنتم تتلون الكتاب أفلا تعقلون (44)",
	 "واستعينوا بالصبر والصلاة وإنها لكبيرة إلا على الخاشعين (45)",
	 "الذين يظنون أنهم ملاقو ربهم وأنهم إليه راجعون (46)",
	 "يا بني إسرائيل اذكروا نعمتي التي أنعمت عليكم وأني فضلتكم على العالمين (47)",
	 "واتقوا يوما لا تجزي نفس عن نفس شيئا ولا يقبل منها شفاعة ولا يؤخذ منها عدل ولا هم ينصرون (48)",
	 "وإذ نجيناكم من آل فرعون يسومونكم سوء العذاب يذبحون أبناءكم ويستحيون نساءكم وفي ذلكم بلاء من ربكم عظيم (49)",
	 "وإذ فرقنا بكم البحر فأنجيناكم وأغرقنا آل فرعون وأنتم تنظرون (50)",
	 "وإذ واعدنا موسى أربعين ليلة ثم اتخذتم العجل من بعده وأنتم ظالمون (51)",
	 "ثم عفونا عنكم من بعد ذلك لعلكم تشكرون (52)",
	 "وإذ آتينا موسى الكتاب والفرقان لعلكم تهتدون (53)",
	 "وإذ قال موسى لقومه يا قوم إنكم ظلمتم أنفسكم باتخاذكم العجل فتوبوا إلى بارئكم فاقتلوا أنفسكم ذلكم خير لكم عند بارئكم فتاب عليكم إنه هو التواب الرحيم (54)",
	 "وإذ قلتم يا موسى لن نؤمن لك حتى نرى الله جهرة فأخذتكم الصاعقة وأنتم تنظرون (55)",
	 "ثم بعثناكم من بعد موتكم لعلكم تشكرون (56)",
	 "وظللنا عليكم الغمام وأنزلنا عليكم المن والسلوى كلوا من طيبات ما رزقناكم وما ظلمونا ولكن كانوا أنفسهم يظلمون (57)",
	 "وإذ قلنا ادخلوا هذه القرية فكلوا منها حيث شئتم رغدا وادخلوا الباب سجدا وقولوا حطة نغفر لكم خطاياكم وسنزيد المحسنين (58)",
	 "فبدل الذين ظلموا قولا غير الذي قيل لهم فأنزلنا على الذين ظلموا رجزا من السماء بما كانوا يفسقون (59)",
	 "وإذ استسقى موسى لقومه فقلنا اضرب بعصاك الحجر فانفجرت منه اثنتا عشرة عينا قد علم كل أناس مشربهم كلوا واشربوا من رزق الله ولا تعثوا في الأرض مفسدين (60)",
	 "وإذ قلتم يا موسى لن نصبر على طعام واحد فادع لنا ربك يخرج لنا مما تنبت الأرض من بقلها وقثائها وفومها وعدسها وبصلها قال أتستبدلون الذي هو أدنى بالذي هو خير اهبطوا مصرا فإن لكم ما سألتم وضربت عليهم الذلة والمسكنة وباءوا بغضب من الله ذلك بأنهم كانوا يكفرون بآيات الله ويقتلون النبيين بغير الحق ذلك بما عصوا وكانوا يعتدون (61)",
	 "إن الذين آمنوا والذين هادوا والنصارى والصابئين من آمن بالله واليوم الآخر وعمل صالحا فلهم أجرهم عند ربهم ولا خوف عليهم ولا هم يحزنون (62)",
	 "وإذ أخذنا ميثاقكم ورفعنا فوقكم الطور خذوا ما آتيناكم بقوة واذكروا ما فيه لعلكم تتقون (63)",
	 "ثم توليتم من بعد ذلك فلولا فضل الله عليكم ورحمته لكنتم من الخاسرين (64)",
	 "ولقد علمتم الذين اعتدوا منكم في السبت فقلنا لهم كونوا قردة خاسئين (65)",
	 "فجعلناها نكالا لما بين يديها وما خلفها وموعظة للمتقين (66)",
	 "وإذ قال موسى لقومه إن الله يأمركم أن تذبحوا بقرة قالوا أتتخذنا هزوا قال أعوذ بالله أن أكون من الجاهلين (67)",
	 "قالوا ادع لنا ربك يبين لنا ما هي قال إنه يقول إنها بقرة لا فارض ولا بكر عوان بين ذلك فافعلوا ما تؤمرون (68)",
	 "قالوا ادع لنا ربك يبين لنا ما لونها قال إنه يقول إنها بقرة صفراء فاقع لونها تسر الناظرين (69)",
	 "قالوا ادع لنا ربك يبين لنا ما هي إن البقر تشابه علينا وإنا إن شاء الله لمهتدون (70)",
	 "قال إنه يقول إنها بقرة لا ذلول تثير الأرض ولا تسقي الحرث مسلمة لا شية فيها قالوا الآن جئت بالحق فذبحوها وما كادوا يفعلون (71)",
	 "وإذ قتلتم نفسا فادارأتم فيها والله مخرج ما كنتم تكتمون (72)",
	 "فقلنا اضربوه ببعضها كذلك يحيي الله الموتى ويريكم آياته لعلكم تعقلون (73)",
	 "ثم قست قلوبكم من بعد ذلك فهي كالحجارة أو أشد قسوة وإن من الحجارة لما يتفجر منه الأنهار وإن منها لما يشقق فيخرج منه الماء وإن منها لما يهبط من خشية الله وما الله بغافل عما تعملون (74)",
	 "أفتطمعون أن يؤمنوا لكم وقد كان فريق منهم يسمعون كلام الله ثم يحرفونه من بعد ما عقلوه وهم يعلمون (75)",
	 "وإذا لقوا الذين آمنوا قالوا آمنا وإذا خلا بعضهم إلى بعض قالوا أتحدثونهم بما فتح الله عليكم ليحاجوكم به عند ربكم أفلا تعقلون (76)",
	 "أولا يعلمون أن الله يعلم ما يسرون وما يعلنون (77)",
	 "ومنهم أميون لا يعلمون الكتاب إلا أماني وإن هم إلا يظنون (78)",
	 "فويل للذين يكتبون الكتاب بأيديهم ثم يقولون هذا من عند الله ليشتروا به ثمنا قليلا فويل لهم مما كتبت أيديهم وويل لهم مما يكسبون (79)",
	 "وقالوا لن تمسنا النار إلا أياما معدودة قل أتخذتم عند الله عهدا فلن يخلف الله عهده أم تقولون على الله ما لا تعلمون (80)",
	 "بلى من كسب سيئة وأحاطت به خطيئته فأولئك أصحاب النار هم فيها خالدون (81)",
	 "والذين آمنوا وعملوا الصالحات أولئك أصحاب الجنة هم فيها خالدون (82)",
	 "وإذ أخذنا ميثاق بني إسرائيل لا تعبدون إلا الله وبالوالدين إحسانا وذي القربى واليتامى والمساكين وقولوا للناس حسنا وأقيموا الصلاة وآتوا الزكاة ثم توليتم إلا قليلا منكم وأنتم معرضون (83)",
	 "وإذ أخذنا ميثاقكم لا تسفكون دماءكم ولا تخرجون أنفسكم من دياركم ثم أقررتم وأنتم تشهدون (84)",
	 "ثم أنتم هؤلاء تقتلون أنفسكم وتخرجون فريقا منكم من ديارهم تظاهرون عليهم بالإثم والعدوان وإن يأتوكم أسارى تفادوهم وهو محرم عليكم إخراجهم أفتؤمنون ببعض الكتاب وتكفرون ببعض فما جزاء من يفعل ذلك منكم إلا خزي في الحياة الدنيا ويوم القيامة يردون إلى أشد العذاب وما الله بغافل عما تعملون (85)",
	 "أولئك الذين اشتروا الحياة الدنيا بالآخرة فلا يخفف عنهم العذاب ولا هم ينصرون (86)",
	 "ولقد آتينا موسى الكتاب وقفينا من بعده بالرسل وآتينا عيسى ابن مريم البينات وأيدناه بروح القدس أفكلما جاءكم رسول بما لا تهوى أنفسكم استكبرتم ففريقا كذبتم وفريقا تقتلون (87)",
	 "وقالوا قلوبنا غلف بل لعنهم الله بكفرهم فقليلا ما يؤمنون (88)",
	 "ولما جاءهم كتاب من عند الله مصدق لما معهم وكانوا من قبل يستفتحون على الذين كفروا فلما جاءهم ما عرفوا كفروا به فلعنة الله على الكافرين (89)",
	 "بئسما اشتروا به أنفسهم أن يكفروا بما أنزل الله بغيا أن ينزل الله من فضله على من يشاء من عباده فباءوا بغضب على غضب وللكافرين عذاب مهين (90)",
	 "وإذا قيل لهم آمنوا بما أنزل الله قالوا نؤمن بما أنزل علينا ويكفرون بما وراءه وهو الحق مصدقا لما معهم قل فلم تقتلون أنبياء الله من قبل إن كنتم مؤمنين (91)",
	 "ولقد جاءكم موسى بالبينات ثم اتخذتم العجل من بعده وأنتم ظالمون (92)",
	 "وإذ أخذنا ميثاقكم ورفعنا فوقكم الطور خذوا ما آتيناكم بقوة واسمعوا قالوا سمعنا وعصينا وأشربوا في قلوبهم العجل بكفرهم قل بئسما يأمركم به إيمانكم إن كنتم مؤمنين (93)",
	 "قل إن كانت لكم الدار الآخرة عند الله خالصة من دون الناس فتمنوا الموت إن كنتم صادقين (94)",
	 "ولن يتمنوه أبدا بما قدمت أيديهم والله عليم بالظالمين (95)",
	 "ولتجدنهم أحرص الناس على حياة ومن الذين أشركوا يود أحدهم لو يعمر ألف سنة وما هو بمزحزحه من العذاب أن يعمر والله بصير بما يعملون (96)",
	 "قل من كان عدوا لجبريل فإنه نزله على قلبك بإذن الله مصدقا لما بين يديه وهدى وبشرى للمؤمنين (97)",
	 "من كان عدوا لله وملائكته ورسله وجبريل وميكال فإن الله عدو للكافرين (98)",
	 "ولقد أنزلنا إليك آيات بينات وما يكفر بها إلا الفاسقون (99)",
	 "أوكلما عاهدوا عهدا نبذه فريق منهم بل أكثرهم لا يؤمنون (100)",
	 "ولما جاءهم رسول من عند الله مصدق لما معهم نبذ فريق من الذين أوتوا الكتاب كتاب الله وراء ظهورهم كأنهم لا يعلمون (101)",
	 "واتبعوا ما تتلو الشياطين على ملك سليمان وما كفر سليمان ولكن الشياطين كفروا يعلمون الناس السحر وما أنزل على الملكين ببابل هاروت وماروت وما يعلمان من أحد حتى يقولا إنما نحن فتنة فلا تكفر فيتعلمون منهما ما يفرقون به بين المرء وزوجه وما هم بضارين به من أحد إلا بإذن الله ويتعلمون ما يضرهم ولا ينفعهم ولقد علموا لمن اشتراه ما له في الآخرة من خلاق ولبئس ما شروا به أنفسهم لو كانوا يعلمون (102)",
	 "ولو أنهم آمنوا واتقوا لمثوبة من عند الله خير لو كانوا يعلمون (103)",
	 "يا أيها الذين آمنوا لا تقولوا راعنا وقولوا انظرنا واسمعوا وللكافرين عذاب أليم (104)",
	 "ما يود الذين كفروا من أهل الكتاب ولا المشركين أن ينزل عليكم من خير من ربكم والله يختص برحمته من يشاء والله ذو الفضل العظيم (105)",
	 "ما ننسخ من آية أو ننسها نأت بخير منها أو مثلها ألم تعلم أن الله على كل شيء قدير (106)",
	 "ألم تعلم أن الله له ملك السماوات والأرض وما لكم من دون الله من ولي ولا نصير (107)",
	 "أم تريدون أن تسألوا رسولكم كما سئل موسى من قبل ومن يتبدل الكفر بالإيمان فقد ضل سواء السبيل (108)",
	 "ود كثير من أهل الكتاب لو يردونكم من بعد إيمانكم كفارا حسدا من عند أنفسهم من بعد ما تبين لهم الحق فاعفوا واصفحوا حتى يأتي الله بأمره إن الله على كل شيء قدير (109)",
	 "وأقيموا الصلاة وآتوا الزكاة وما تقدموا لأنفسكم من خير تجدوه عند الله إن الله بما تعملون بصير (110)",
	 "وقالوا لن يدخل الجنة إلا من كان هودا أو نصارى تلك أمانيهم قل هاتوا برهانكم إن كنتم صادقين (111)",
	 "بلى من أسلم وجهه لله وهو محسن فله أجره عند ربه ولا خوف عليهم ولا هم يحزنون (112)",
	 "وقالت اليهود ليست النصارى على شيء وقالت النصارى ليست اليهود على شيء وهم يتلون الكتاب كذلك قال الذين لا يعلمون مثل قولهم فالله يحكم بينهم يوم القيامة فيما كانوا فيه يختلفون (113)",
	 "ومن أظلم ممن منع مساجد الله أن يذكر فيها اسمه وسعى في خرابها أولئك ما كان لهم أن يدخلوها إلا خائفين لهم في الدنيا خزي ولهم في الآخرة عذاب عظيم (114)",
	 "ولله المشرق والمغرب فأينما تولوا فثم وجه الله إن الله واسع عليم (115)",
	 "وقالوا اتخذ الله ولدا سبحانه بل له ما في السماوات والأرض كل له قانتون (116)",
	 "بديع السماوات والأرض وإذا قضى أمرا فإنما يقول له كن فيكون (117)",
	 "وقال الذين لا يعلمون لولا يكلمنا الله أو تأتينا آية كذلك قال الذين من قبلهم مثل قولهم تشابهت قلوبهم قد بينا الآيات لقوم يوقنون (118)",
	 "إنا أرسلناك بالحق بشيرا ونذيرا ولا تسأل عن أصحاب الجحيم (119)",
	 "ولن ترضى عنك اليهود ولا النصارى حتى تتبع ملتهم قل إن هدى الله هو الهدى ولئن اتبعت أهواءهم بعد الذي جاءك من العلم ما لك من الله من ولي ولا نصير (120)",
	 "الذين آتيناهم الكتاب يتلونه حق تلاوته أولئك يؤمنون به ومن يكفر به فأولئك هم الخاسرون (121)",
	 "يا بني إسرائيل اذكروا نعمتي التي أنعمت عليكم وأني فضلتكم على العالمين (122)",
	 "واتقوا يوما لا تجزي نفس عن نفس شيئا ولا يقبل منها عدل ولا تنفعها شفاعة ولا هم ينصرون (123)",
	 "وإذ ابتلى إبراهيم ربه بكلمات فأتمهن قال إني جاعلك للناس إماما قال ومن ذريتي قال لا ينال عهدي الظالمين (124)",
	 "وإذ جعلنا البيت مثابة للناس وأمنا واتخذوا من مقام إبراهيم مصلى وعهدنا إلى إبراهيم وإسماعيل أن طهرا بيتي للطائفين والعاكفين والركع السجود (125)",
	 "وإذ قال إبراهيم رب اجعل هذا بلدا آمنا وارزق أهله من الثمرات من آمن منهم بالله واليوم الآخر قال ومن كفر فأمتعه قليلا ثم أضطره إلى عذاب النار وبئس المصير (126)",
	 "وإذ يرفع إبراهيم القواعد من البيت وإسماعيل ربنا تقبل منا إنك أنت السميع العليم (127)",
	 "ربنا واجعلنا مسلمين لك ومن ذريتنا أمة مسلمة لك وأرنا مناسكنا وتب علينا إنك أنت التواب الرحيم (128)",
	 "ربنا وابعث فيهم رسولا منهم يتلو عليهم آياتك ويعلمهم الكتاب والحكمة ويزكيهم إنك أنت العزيز الحكيم (129)",
	 "ومن يرغب عن ملة إبراهيم إلا من سفه نفسه ولقد اصطفيناه في الدنيا وإنه في الآخرة لمن الصالحين (130)",
	 "إذ قال له ربه أسلم قال أسلمت لرب العالمين (131)",
	 "ووصى بها إبراهيم بنيه ويعقوب يا بني إن الله اصطفى لكم الدين فلا تموتن إلا وأنتم مسلمون (132)",
	 "أم كنتم شهداء إذ حضر يعقوب الموت إذ قال لبنيه ما تعبدون من بعدي قالوا نعبد إلهك وإله آبائك إبراهيم وإسماعيل وإسحاق إلها واحدا ونحن له مسلمون (133)",
	 "تلك أمة قد خلت لها ما كسبت ولكم ما كسبتم ولا تسألون عما كانوا يعملون (134)",
	 "وقالوا كونوا هودا أو نصارى تهتدوا قل بل ملة إبراهيم حنيفا وما كان من المشركين (135)",
	 "قولوا آمنا بالله وما أنزل إلينا وما أنزل إلى إبراهيم وإسماعيل وإسحاق ويعقوب والأسباط وما أوتي موسى وعيسى وما أوتي النبيون من ربهم لا نفرق بين أحد منهم ونحن له مسلمون (136)",
	 "فإن آمنوا بمثل ما آمنتم به فقد اهتدوا وإن تولوا فإنما هم في شقاق فسيكفيكهم الله وهو السميع العليم (137)",
	 "صبغة الله ومن أحسن من الله صبغة ونحن له عابدون (138)",
	 "قل أتحاجوننا في الله وهو ربنا وربكم ولنا أعمالنا ولكم أعمالكم ونحن له مخلصون (139)",
	 "أم تقولون إن إبراهيم وإسماعيل وإسحاق ويعقوب والأسباط كانوا هودا أو نصارى قل أأنتم أعلم أم الله ومن أظلم ممن كتم شهادة عنده من الله وما الله بغافل عما تعملون (140)",
	 "تلك أمة قد خلت لها ما كسبت ولكم ما كسبتم ولا تسألون عما كانوا يعملون (141)",
	 "سيقول السفهاء من الناس ما ولاهم عن قبلتهم التي كانوا عليها قل لله المشرق والمغرب يهدي من يشاء إلى صراط مستقيم (142)",
	 "وكذلك جعلناكم أمة وسطا لتكونوا شهداء على الناس ويكون الرسول عليكم شهيدا وما جعلنا القبلة التي كنت عليها إلا لنعلم من يتبع الرسول ممن ينقلب على عقبيه وإن كانت لكبيرة إلا على الذين هدى الله وما كان الله ليضيع إيمانكم إن الله بالناس لرءوف رحيم (143)",
	 "قد نرى تقلب وجهك في السماء فلنولينك قبلة ترضاها فول وجهك شطر المسجد الحرام وحيث ما كنتم فولوا وجوهكم شطره وإن الذين أوتوا الكتاب ليعلمون أنه الحق من ربهم وما الله بغافل عما يعملون (144)",
	 "ولئن أتيت الذين أوتوا الكتاب بكل آية ما تبعوا قبلتك وما أنت بتابع قبلتهم وما بعضهم بتابع قبلة بعض ولئن اتبعت أهواءهم من بعد ما جاءك من العلم إنك إذا لمن الظالمين (145)",
	 "الذين آتيناهم الكتاب يعرفونه كما يعرفون أبناءهم وإن فريقا منهم ليكتمون الحق وهم يعلمون (146)",
	 "الحق من ربك فلا تكونن من الممترين (147)",
	 "ولكل وجهة هو موليها فاستبقوا الخيرات أين ما تكونوا يأت بكم الله جميعا إن الله على كل شيء قدير (148)",
	 "ومن حيث خرجت فول وجهك شطر المسجد الحرام وإنه للحق من ربك وما الله بغافل عما تعملون (149)",
	 "ومن حيث خرجت فول وجهك شطر المسجد الحرام وحيث ما كنتم فولوا وجوهكم شطره لئلا يكون للناس عليكم حجة إلا الذين ظلموا منهم فلا تخشوهم واخشوني ولأتم نعمتي عليكم ولعلكم تهتدون (150)",
	 "كما أرسلنا فيكم رسولا منكم يتلو عليكم آياتنا ويزكيكم ويعلمكم الكتاب والحكمة ويعلمكم ما لم تكونوا تعلمون (151)",
	 "فاذكروني أذكركم واشكروا لي ولا تكفرون (152)",
	 "يا أيها الذين آمنوا استعينوا بالصبر والصلاة إن الله مع الصابرين (153)",
	 "ولا تقولوا لمن يقتل في سبيل الله أموات بل أحياء ولكن لا تشعرون (154)",
	 "ولنبلونكم بشيء من الخوف والجوع ونقص من الأموال والأنفس والثمرات وبشر الصابرين (155)",
	 "الذين إذا أصابتهم مصيبة قالوا إنا لله وإنا إليه راجعون (156)",
	 "أولئك عليهم صلوات من ربهم ورحمة وأولئك هم المهتدون (157)",
	 "إن الصفا والمروة من شعائر الله فمن حج البيت أو اعتمر فلا جناح عليه أن يطوف بهما ومن تطوع خيرا فإن الله شاكر عليم (158)",
	 "إن الذين يكتمون ما أنزلنا من البينات والهدى من بعد ما بيناه للناس في الكتاب أولئك يلعنهم الله ويلعنهم اللاعنون (159)",
	 "إلا الذين تابوا وأصلحوا وبينوا فأولئك أتوب عليهم وأنا التواب الرحيم (160)",
	 "إن الذين كفروا وماتوا وهم كفار أولئك عليهم لعنة الله والملائكة والناس أجمعين (161)",
	 "خالدين فيها لا يخفف عنهم العذاب ولا هم ينظرون (162)",
	 "وإلهكم إله واحد لا إله إلا هو الرحمن الرحيم (163)",
	 "إن في خلق السماوات والأرض واختلاف الليل والنهار والفلك التي تجري في البحر بما ينفع الناس وما أنزل الله من السماء من ماء فأحيا به الأرض بعد موتها وبث فيها من كل دابة وتصريف الرياح والسحاب المسخر بين السماء والأرض لآيات لقوم يعقلون (164)",
	 "ومن الناس من يتخذ من دون الله أندادا يحبونهم كحب الله والذين آمنوا أشد حبا لله ولو يرى الذين ظلموا إذ يرون العذاب أن القوة لله جميعا وأن الله شديد العذاب (165)",
	 "إذ تبرأ الذين اتبعوا من الذين اتبعوا ورأوا العذاب وتقطعت بهم الأسباب (166)",
	 "وقال الذين اتبعوا لو أن لنا كرة فنتبرأ منهم كما تبرءوا منا كذلك يريهم الله أعمالهم حسرات عليهم وما هم بخارجين من النار (167)",
	 "يا أيها الناس كلوا مما في الأرض حلالا طيبا ولا تتبعوا خطوات الشيطان إنه لكم عدو مبين (168)",
	 "إنما يأمركم بالسوء والفحشاء وأن تقولوا على الله ما لا تعلمون (169)",
	 "وإذا قيل لهم اتبعوا ما أنزل الله قالوا بل نتبع ما ألفينا عليه آباءنا أولو كان آباؤهم لا يعقلون شيئا ولا يهتدون (170)",
	 "ومثل الذين كفروا كمثل الذي ينعق بما لا يسمع إلا دعاء ونداء صم بكم عمي فهم لا يعقلون (171)",
	 "يا أيها الذين آمنوا كلوا من طيبات ما رزقناكم واشكروا لله إن كنتم إياه تعبدون (172)",
	 "إنما حرم عليكم الميتة والدم ولحم الخنزير وما أهل به لغير الله فمن اضطر غير باغ ولا عاد فلا إثم عليه إن الله غفور رحيم (173)",
	 "إن الذين يكتمون ما أنزل الله من الكتاب ويشترون به ثمنا قليلا أولئك ما يأكلون في بطونهم إلا النار ولا يكلمهم الله يوم القيامة ولا يزكيهم ولهم عذاب أليم (174)",
	 "أولئك الذين اشتروا الضلالة بالهدى والعذاب بالمغفرة فما أصبرهم على النار (175)",
	 "ذلك بأن الله نزل الكتاب بالحق وإن الذين اختلفوا في الكتاب لفي شقاق بعيد (176)",
	 "ليس البر أن تولوا وجوهكم قبل المشرق والمغرب ولكن البر من آمن بالله واليوم الآخر والملائكة والكتاب والنبيين وآتى المال على حبه ذوي القربى واليتامى والمساكين وابن السبيل والسائلين وفي الرقاب وأقام الصلاة وآتى الزكاة والموفون بعهدهم إذا عاهدوا والصابرين في البأساء والضراء وحين البأس أولئك الذين صدقوا وأولئك هم المتقون (177)",
	 "يا أيها الذين آمنوا كتب عليكم القصاص في القتلى الحر بالحر والعبد بالعبد والأنثى بالأنثى فمن عفي له من أخيه شيء فاتباع بالمعروف وأداء إليه بإحسان ذلك تخفيف من ربكم ورحمة فمن اعتدى بعد ذلك فله عذاب أليم (178)",
	 "ولكم في القصاص حياة يا أولي الألباب لعلكم تتقون (179)",
	 "كتب عليكم إذا حضر أحدكم الموت إن ترك خيرا الوصية للوالدين والأقربين بالمعروف حقا على المتقين (180)",
	 "فمن بدله بعدما سمعه فإنما إثمه على الذين يبدلونه إن الله سميع عليم (181)",
	 "فمن خاف من موص جنفا أو إثما فأصلح بينهم فلا إثم عليه إن الله غفور رحيم (182)",
	 "يا أيها الذين آمنوا كتب عليكم الصيام كما كتب على الذين من قبلكم لعلكم تتقون (183)",
	 "أياما معدودات فمن كان منكم مريضا أو على سفر فعدة من أيام أخر وعلى الذين يطيقونه فدية طعام مسكين فمن تطوع خيرا فهو خير له وأن تصوموا خير لكم إن كنتم تعلمون (184)",
	 "شهر رمضان الذي أنزل فيه القرآن هدى للناس وبينات من الهدى والفرقان فمن شهد منكم الشهر فليصمه ومن كان مريضا أو على سفر فعدة من أيام أخر يريد الله بكم اليسر ولا يريد بكم العسر ولتكملوا العدة ولتكبروا الله على ما هداكم ولعلكم تشكرون (185)",
	 "وإذا سألك عبادي عني فإني قريب أجيب دعوة الداع إذا دعان فليستجيبوا لي وليؤمنوا بي لعلهم يرشدون (186)",
	 "أحل لكم ليلة الصيام الرفث إلى نسائكم هن لباس لكم وأنتم لباس لهن علم الله أنكم كنتم تختانون أنفسكم فتاب عليكم وعفا عنكم فالآن باشروهن وابتغوا ما كتب الله لكم وكلوا واشربوا حتى يتبين لكم الخيط الأبيض من الخيط الأسود من الفجر ثم أتموا الصيام إلى الليل ولا تباشروهن وأنتم عاكفون في المساجد تلك حدود الله فلا تقربوها كذلك يبين الله آياته للناس لعلهم يتقون (187)",
	 "ولا تأكلوا أموالكم بينكم بالباطل وتدلوا بها إلى الحكام لتأكلوا فريقا من أموال الناس بالإثم وأنتم تعلمون (188)",
	 "يسألونك عن الأهلة قل هي مواقيت للناس والحج وليس البر بأن تأتوا البيوت من ظهورها ولكن البر من اتقى وأتوا البيوت من أبوابها واتقوا الله لعلكم تفلحون (189)",
	 "وقاتلوا في سبيل الله الذين يقاتلونكم ولا تعتدوا إن الله لا يحب المعتدين (190)",
	 "واقتلوهم حيث ثقفتموهم وأخرجوهم من حيث أخرجوكم والفتنة أشد من القتل ولا تقاتلوهم عند المسجد الحرام حتى يقاتلوكم فيه فإن قاتلوكم فاقتلوهم كذلك جزاء الكافرين (191)",
	 "فإن انتهوا فإن الله غفور رحيم (192)",
	 "وقاتلوهم حتى لا تكون فتنة ويكون الدين لله فإن انتهوا فلا عدوان إلا على الظالمين (193)",
	 "الشهر الحرام بالشهر الحرام والحرمات قصاص فمن اعتدى عليكم فاعتدوا عليه بمثل ما اعتدى عليكم واتقوا الله واعلموا أن الله مع المتقين (194)",
	 "وأنفقوا في سبيل الله ولا تلقوا بأيديكم إلى التهلكة وأحسنوا إن الله يحب المحسنين (195)",
	 "وأتموا الحج والعمرة لله فإن أحصرتم فما استيسر من الهدي ولا تحلقوا رءوسكم حتى يبلغ الهدي محله فمن كان منكم مريضا أو به أذى من رأسه ففدية من صيام أو صدقة أو نسك فإذا أمنتم فمن تمتع بالعمرة إلى الحج فما استيسر من الهدي فمن لم يجد فصيام ثلاثة أيام في الحج وسبعة إذا رجعتم تلك عشرة كاملة ذلك لمن لم يكن أهله حاضري المسجد الحرام واتقوا الله واعلموا أن الله شديد العقاب (196)",
	 "الحج أشهر معلومات فمن فرض فيهن الحج فلا رفث ولا فسوق ولا جدال في الحج وما تفعلوا من خير يعلمه الله وتزودوا فإن خير الزاد التقوى واتقون يا أولي الألباب (197)",
	 "ليس عليكم جناح أن تبتغوا فضلا من ربكم فإذا أفضتم من عرفات فاذكروا الله عند المشعر الحرام واذكروه كما هداكم وإن كنتم من قبله لمن الضالين (198)",
	 "ثم أفيضوا من حيث أفاض الناس واستغفروا الله إن الله غفور رحيم (199)",
	 "فإذا قضيتم مناسككم فاذكروا الله كذكركم آباءكم أو أشد ذكرا فمن الناس من يقول ربنا آتنا في الدنيا وما له في الآخرة من خلاق (200)",
	 "ومنهم من يقول ربنا آتنا في الدنيا حسنة وفي الآخرة حسنة وقنا عذاب النار (201)",
	 "أولئك لهم نصيب مما كسبوا والله سريع الحساب (202)",
	 "واذكروا الله في أيام معدودات فمن تعجل في يومين فلا إثم عليه ومن تأخر فلا إثم عليه لمن اتقى واتقوا الله واعلموا أنكم إليه تحشرون (203)",
	 "ومن الناس من يعجبك قوله في الحياة الدنيا ويشهد الله على ما في قلبه وهو ألد الخصام (204)",
	 "وإذا تولى سعى في الأرض ليفسد فيها ويهلك الحرث والنسل والله لا يحب الفساد (205)",
	 "وإذا قيل له اتق الله أخذته العزة بالإثم فحسبه جهنم ولبئس المهاد (206)",
	 "ومن الناس من يشري نفسه ابتغاء مرضات الله والله رءوف بالعباد (207)",
	 "يا أيها الذين آمنوا ادخلوا في السلم كافة ولا تتبعوا خطوات الشيطان إنه لكم عدو مبين (208)",
	 "فإن زللتم من بعد ما جاءتكم البينات فاعلموا أن الله عزيز حكيم (209)",
	 "هل ينظرون إلا أن يأتيهم الله في ظلل من الغمام والملائكة وقضي الأمر وإلى الله ترجع الأمور (210)",
	 "سل بني إسرائيل كم آتيناهم من آية بينة ومن يبدل نعمة الله من بعد ما جاءته فإن الله شديد العقاب (211)",
	 "زين للذين كفروا الحياة الدنيا ويسخرون من الذين آمنوا والذين اتقوا فوقهم يوم القيامة والله يرزق من يشاء بغير حساب (212)",
	 "كان الناس أمة واحدة فبعث الله النبيين مبشرين ومنذرين وأنزل معهم الكتاب بالحق ليحكم بين الناس فيما اختلفوا فيه وما اختلف فيه إلا الذين أوتوه من بعد ما جاءتهم البينات بغيا بينهم فهدى الله الذين آمنوا لما اختلفوا فيه من الحق بإذنه والله يهدي من يشاء إلى صراط مستقيم (213)",
	 "أم حسبتم أن تدخلوا الجنة ولما يأتكم مثل الذين خلوا من قبلكم مستهم البأساء والضراء وزلزلوا حتى يقول الرسول والذين آمنوا معه متى نصر الله ألا إن نصر الله قريب (214)",
	 "يسألونك ماذا ينفقون قل ما أنفقتم من خير فللوالدين والأقربين واليتامى والمساكين وابن السبيل وما تفعلوا من خير فإن الله به عليم (215)",
	 "كتب عليكم القتال وهو كره لكم وعسى أن تكرهوا شيئا وهو خير لكم وعسى أن تحبوا شيئا وهو شر لكم والله يعلم وأنتم لا تعلمون (216)",
	 "يسألونك عن الشهر الحرام قتال فيه قل قتال فيه كبير وصد عن سبيل الله وكفر به والمسجد الحرام وإخراج أهله منه أكبر عند الله والفتنة أكبر من القتل ولا يزالون يقاتلونكم حتى يردوكم عن دينكم إن استطاعوا ومن يرتدد منكم عن دينه فيمت وهو كافر فأولئك حبطت أعمالهم في الدنيا والآخرة وأولئك أصحاب النار هم فيها خالدون (217)",
	 "إن الذين آمنوا والذين هاجروا وجاهدوا في سبيل الله أولئك يرجون رحمت الله والله غفور رحيم (218)",
	 "يسألونك عن الخمر والميسر قل فيهما إثم كبير ومنافع للناس وإثمهما أكبر من نفعهما ويسألونك ماذا ينفقون قل العفو كذلك يبين الله لكم الآيات لعلكم تتفكرون (219)",
	 "في الدنيا والآخرة ويسألونك عن اليتامى قل إصلاح لهم خير وإن تخالطوهم فإخوانكم والله يعلم المفسد من المصلح ولو شاء الله لأعنتكم إن الله عزيز حكيم (220)",
	 "ولا تنكحوا المشركات حتى يؤمن ولأمة مؤمنة خير من مشركة ولو أعجبتكم ولا تنكحوا المشركين حتى يؤمنوا ولعبد مؤمن خير من مشرك ولو أعجبكم أولئك يدعون إلى النار والله يدعو إلى الجنة والمغفرة بإذنه ويبين آياته للناس لعلهم يتذكرون (221)",
	 "ويسألونك عن المحيض قل هو أذى فاعتزلوا النساء في المحيض ولا تقربوهن حتى يطهرن فإذا تطهرن فأتوهن من حيث أمركم الله إن الله يحب التوابين ويحب المتطهرين (222)",
	 "نساؤكم حرث لكم فأتوا حرثكم أنى شئتم وقدموا لأنفسكم واتقوا الله واعلموا أنكم ملاقوه وبشر المؤمنين (223)",
	 "ولا تجعلوا الله عرضة لأيمانكم أن تبروا وتتقوا وتصلحوا بين الناس والله سميع عليم (224)",
	 "لا يؤاخذكم الله باللغو في أيمانكم ولكن يؤاخذكم بما كسبت قلوبكم والله غفور حليم (225)",
	 "للذين يؤلون من نسائهم تربص أربعة أشهر فإن فاءوا فإن الله غفور رحيم (226)",
	 "وإن عزموا الطلاق فإن الله سميع عليم (227)",
	 "والمطلقات يتربصن بأنفسهن ثلاثة قروء ولا يحل لهن أن يكتمن ما خلق الله في أرحامهن إن كن يؤمن بالله واليوم الآخر وبعولتهن أحق بردهن في ذلك إن أرادوا إصلاحا ولهن مثل الذي عليهن بالمعروف وللرجال عليهن درجة والله عزيز حكيم (228)",
	 "الطلاق مرتان فإمساك بمعروف أو تسريح بإحسان ولا يحل لكم أن تأخذوا مما آتيتموهن شيئا إلا أن يخافا ألا يقيما حدود الله فإن خفتم ألا يقيما حدود الله فلا جناح عليهما فيما افتدت به تلك حدود الله فلا تعتدوها ومن يتعد حدود الله فأولئك هم الظالمون (229)",
	 "فإن طلقها فلا تحل له من بعد حتى تنكح زوجا غيره فإن طلقها فلا جناح عليهما أن يتراجعا إن ظنا أن يقيما حدود الله وتلك حدود الله يبينها لقوم يعلمون (230)",
	 "وإذا طلقتم النساء فبلغن أجلهن فأمسكوهن بمعروف أو سرحوهن بمعروف ولا تمسكوهن ضرارا لتعتدوا ومن يفعل ذلك فقد ظلم نفسه ولا تتخذوا آيات الله هزوا واذكروا نعمت الله عليكم وما أنزل عليكم من الكتاب والحكمة يعظكم به واتقوا الله واعلموا أن الله بكل شيء عليم (231)",
	 "وإذا طلقتم النساء فبلغن أجلهن فلا تعضلوهن أن ينكحن أزواجهن إذا تراضوا بينهم بالمعروف ذلك يوعظ به من كان منكم يؤمن بالله واليوم الآخر ذلكم أزكى لكم وأطهر والله يعلم وأنتم لا تعلمون (232)",
	 "والوالدات يرضعن أولادهن حولين كاملين لمن أراد أن يتم الرضاعة وعلى المولود له رزقهن وكسوتهن بالمعروف لا تكلف نفس إلا وسعها لا تضار والدة بولدها ولا مولود له بولده وعلى الوارث مثل ذلك فإن أرادا فصالا عن تراض منهما وتشاور فلا جناح عليهما وإن أردتم أن تسترضعوا أولادكم فلا جناح عليكم إذا سلمتم ما آتيتم بالمعروف واتقوا الله واعلموا أن الله بما تعملون بصير (233)",
	 "والذين يتوفون منكم ويذرون أزواجا يتربصن بأنفسهن أربعة أشهر وعشرا فإذا بلغن أجلهن فلا جناح عليكم فيما فعلن في أنفسهن بالمعروف والله بما تعملون خبير (234)",
	 "ولا جناح عليكم فيما عرضتم به من خطبة النساء أو أكننتم في أنفسكم علم الله أنكم ستذكرونهن ولكن لا تواعدوهن سرا إلا أن تقولوا قولا معروفا ولا تعزموا عقدة النكاح حتى يبلغ الكتاب أجله واعلموا أن الله يعلم ما في أنفسكم فاحذروه واعلموا أن الله غفور حليم (235)",
	 "لا جناح عليكم إن طلقتم النساء ما لم تمسوهن أو تفرضوا لهن فريضة ومتعوهن على الموسع قدره وعلى المقتر قدره متاعا بالمعروف حقا على المحسنين (236)",
	 "وإن طلقتموهن من قبل أن تمسوهن وقد فرضتم لهن فريضة فنصف ما فرضتم إلا أن يعفون أو يعفو الذي بيده عقدة النكاح وأن تعفوا أقرب للتقوى ولا تنسوا الفضل بينكم إن الله بما تعملون بصير (237)",
	 "حافظوا على الصلوات والصلاة الوسطى وقوموا لله قانتين (238)",
	 "فإن خفتم فرجالا أو ركبانا فإذا أمنتم فاذكروا الله كما علمكم ما لم تكونوا تعلمون (239)",
	 "والذين يتوفون منكم ويذرون أزواجا وصية لأزواجهم متاعا إلى الحول غير إخراج فإن خرجن فلا جناح عليكم في ما فعلن في أنفسهن من معروف والله عزيز حكيم (240)",
	 "وللمطلقات متاع بالمعروف حقا على المتقين (241)",
	 "كذلك يبين الله لكم آياته لعلكم تعقلون (242)",
	 "ألم تر إلى الذين خرجوا من ديارهم وهم ألوف حذر الموت فقال لهم الله موتوا ثم أحياهم إن الله لذو فضل على الناس ولكن أكثر الناس لا يشكرون (243)",
	 "وقاتلوا في سبيل الله واعلموا أن الله سميع عليم (244)",
	 "من ذا الذي يقرض الله قرضا حسنا فيضاعفه له أضعافا كثيرة والله يقبض ويبسط وإليه ترجعون (245)",
	 "ألم تر إلى الملإ من بني إسرائيل من بعد موسى إذ قالوا لنبي لهم ابعث لنا ملكا نقاتل في سبيل الله قال هل عسيتم إن كتب عليكم القتال ألا تقاتلوا قالوا وما لنا ألا نقاتل في سبيل الله وقد أخرجنا من ديارنا وأبنائنا فلما كتب عليهم القتال تولوا إلا قليلا منهم والله عليم بالظالمين (246)",
	 "وقال لهم نبيهم إن الله قد بعث لكم طالوت ملكا قالوا أنى يكون له الملك علينا ونحن أحق بالملك منه ولم يؤت سعة من المال قال إن الله اصطفاه عليكم وزاده بسطة في العلم والجسم والله يؤتي ملكه من يشاء والله واسع عليم (247)",
	 "وقال لهم نبيهم إن آية ملكه أن يأتيكم التابوت فيه سكينة من ربكم وبقية مما ترك آل موسى وآل هارون تحمله الملائكة إن في ذلك لآية لكم إن كنتم مؤمنين (248)",
	 "فلما فصل طالوت بالجنود قال إن الله مبتليكم بنهر فمن شرب منه فليس مني ومن لم يطعمه فإنه مني إلا من اغترف غرفة بيده فشربوا منه إلا قليلا منهم فلما جاوزه هو والذين آمنوا معه قالوا لا طاقة لنا اليوم بجالوت وجنوده قال الذين يظنون أنهم ملاقو الله كم من فئة قليلة غلبت فئة كثيرة بإذن الله والله مع الصابرين (249)",
	 "ولما برزوا لجالوت وجنوده قالوا ربنا أفرغ علينا صبرا وثبت أقدامنا وانصرنا على القوم الكافرين (250)",
	 "فهزموهم بإذن الله وقتل داوود جالوت وآتاه الله الملك والحكمة وعلمه مما يشاء ولولا دفع الله الناس بعضهم ببعض لفسدت الأرض ولكن الله ذو فضل على العالمين (251)",
	 "تلك آيات الله نتلوها عليك بالحق وإنك لمن المرسلين (252)",
	 "تلك الرسل فضلنا بعضهم على بعض منهم من كلم الله ورفع بعضهم درجات وآتينا عيسى ابن مريم البينات وأيدناه بروح القدس ولو شاء الله ما اقتتل الذين من بعدهم من بعد ما جاءتهم البينات ولكن اختلفوا فمنهم من آمن ومنهم من كفر ولو شاء الله ما اقتتلوا ولكن الله يفعل ما يريد (253)",
	 "يا أيها الذين آمنوا أنفقوا مما رزقناكم من قبل أن يأتي يوم لا بيع فيه ولا خلة ولا شفاعة والكافرون هم الظالمون (254)",
	 "الله لا إله إلا هو الحي القيوم لا تأخذه سنة ولا نوم له ما في السماوات وما في الأرض من ذا الذي يشفع عنده إلا بإذنه يعلم ما بين أيديهم وما خلفهم ولا يحيطون بشيء من علمه إلا بما شاء وسع كرسيه السماوات والأرض ولا يئوده حفظهما وهو العلي العظيم (255)",
	 "لا إكراه في الدين قد تبين الرشد من الغي فمن يكفر بالطاغوت ويؤمن بالله فقد استمسك بالعروة الوثقى لا انفصام لها والله سميع عليم (256)",
	 "الله ولي الذين آمنوا يخرجهم من الظلمات إلى النور والذين كفروا أولياؤهم الطاغوت يخرجونهم من النور إلى الظلمات أولئك أصحاب النار هم فيها خالدون (257)",
	 "ألم تر إلى الذي حاج إبراهيم في ربه أن آتاه الله الملك إذ قال إبراهيم ربي الذي يحيي ويميت قال أنا أحيي وأميت قال إبراهيم فإن الله يأتي بالشمس من المشرق فأت بها من المغرب فبهت الذي كفر والله لا يهدي القوم الظالمين (258)",
	 "أو كالذي مر على قرية وهي خاوية على عروشها قال أنى يحيي هذه الله بعد موتها فأماته الله مائة عام ثم بعثه قال كم لبثت قال لبثت يوما أو بعض يوم قال بل لبثت مائة عام فانظر إلى طعامك وشرابك لم يتسنه وانظر إلى حمارك ولنجعلك آية للناس وانظر إلى العظام كيف ننشزها ثم نكسوها لحما فلما تبين له قال أعلم أن الله على كل شيء قدير (259)",
	 "وإذ قال إبراهيم رب أرني كيف تحيي الموتى قال أولم تؤمن قال بلى ولكن ليطمئن قلبي قال فخذ أربعة من الطير فصرهن إليك ثم اجعل على كل جبل منهن جزءا ثم ادعهن يأتينك سعيا واعلم أن الله عزيز حكيم (260)",
	 "مثل الذين ينفقون أموالهم في سبيل الله كمثل حبة أنبتت سبع سنابل في كل سنبلة مائة حبة والله يضاعف لمن يشاء والله واسع عليم (261)",
	 "الذين ينفقون أموالهم في سبيل الله ثم لا يتبعون ما أنفقوا منا ولا أذى لهم أجرهم عند ربهم ولا خوف عليهم ولا هم يحزنون (262)",
	 "قول معروف ومغفرة خير من صدقة يتبعها أذى والله غني حليم (263)",
	 "يا أيها الذين آمنوا لا تبطلوا صدقاتكم بالمن والأذى كالذي ينفق ماله رئاء الناس ولا يؤمن بالله واليوم الآخر فمثله كمثل صفوان عليه تراب فأصابه وابل فتركه صلدا لا يقدرون على شيء مما كسبوا والله لا يهدي القوم الكافرين (264)",
	 "ومثل الذين ينفقون أموالهم ابتغاء مرضات الله وتثبيتا من أنفسهم كمثل جنة بربوة أصابها وابل فآتت أكلها ضعفين فإن لم يصبها وابل فطل والله بما تعملون بصير (265)",
	 "أيود أحدكم أن تكون له جنة من نخيل وأعناب تجري من تحتها الأنهار له فيها من كل الثمرات وأصابه الكبر وله ذرية ضعفاء فأصابها إعصار فيه نار فاحترقت كذلك يبين الله لكم الآيات لعلكم تتفكرون (266)",
	 "يا أيها الذين آمنوا أنفقوا من طيبات ما كسبتم ومما أخرجنا لكم من الأرض ولا تيمموا الخبيث منه تنفقون ولستم بآخذيه إلا أن تغمضوا فيه واعلموا أن الله غني حميد (267)",
	 "الشيطان يعدكم الفقر ويأمركم بالفحشاء والله يعدكم مغفرة منه وفضلا والله واسع عليم (268)",
	 "يؤتي الحكمة من يشاء ومن يؤت الحكمة فقد أوتي خيرا كثيرا وما يذكر إلا أولو الألباب (269)",
	 "وما أنفقتم من نفقة أو نذرتم من نذر فإن الله يعلمه وما للظالمين من أنصار (270)",
	 "إن تبدوا الصدقات فنعما هي وإن تخفوها وتؤتوها الفقراء فهو خير لكم ويكفر عنكم من سيئاتكم والله بما تعملون خبير (271)",
	 "ليس عليك هداهم ولكن الله يهدي من يشاء وما تنفقوا من خير فلأنفسكم وما تنفقون إلا ابتغاء وجه الله وما تنفقوا من خير يوف إليكم وأنتم لا تظلمون (272)",
	 "للفقراء الذين أحصروا في سبيل الله لا يستطيعون ضربا في الأرض يحسبهم الجاهل أغنياء من التعفف تعرفهم بسيماهم لا يسألون الناس إلحافا وما تنفقوا من خير فإن الله به عليم (273)",
	 "الذين ينفقون أموالهم بالليل والنهار سرا وعلانية فلهم أجرهم عند ربهم ولا خوف عليهم ولا هم يحزنون (274)",
	 "الذين يأكلون الربا لا يقومون إلا كما يقوم الذي يتخبطه الشيطان من المس ذلك بأنهم قالوا إنما البيع مثل الربا وأحل الله البيع وحرم الربا فمن جاءه موعظة من ربه فانتهى فله ما سلف وأمره إلى الله ومن عاد فأولئك أصحاب النار هم فيها خالدون (275)",
	 "يمحق الله الربا ويربي الصدقات والله لا يحب كل كفار أثيم (276)",
	 "إن الذين آمنوا وعملوا الصالحات وأقاموا الصلاة وآتوا الزكاة لهم أجرهم عند ربهم ولا خوف عليهم ولا هم يحزنون (277)",
	 "يا أيها الذين آمنوا اتقوا الله وذروا ما بقي من الربا إن كنتم مؤمنين (278)",
	 "فإن لم تفعلوا فأذنوا بحرب من الله ورسوله وإن تبتم فلكم رءوس أموالكم لا تظلمون ولا تظلمون (279)",
	 "وإن كان ذو عسرة فنظرة إلى ميسرة وأن تصدقوا خير لكم إن كنتم تعلمون (280)",
	 "واتقوا يوما ترجعون فيه إلى الله ثم توفى كل نفس ما كسبت وهم لا يظلمون (281)",
	 "يا أيها الذين آمنوا إذا تداينتم بدين إلى أجل مسمى فاكتبوه وليكتب بينكم كاتب بالعدل ولا يأب كاتب أن يكتب كما علمه الله فليكتب وليملل الذي عليه الحق وليتق الله ربه ولا يبخس منه شيئا فإن كان الذي عليه الحق سفيها أو ضعيفا أو لا يستطيع أن يمل هو فليملل وليه بالعدل واستشهدوا شهيدين من رجالكم فإن لم يكونا رجلين فرجل وامرأتان ممن ترضون من الشهداء أن تضل إحداهما فتذكر إحداهما الأخرى ولا يأب الشهداء إذا ما دعوا ولا تسأموا أن تكتبوه صغيرا أو كبيرا إلى أجله ذلكم أقسط عند الله وأقوم للشهادة وأدنى ألا ترتابوا إلا أن تكون تجارة حاضرة تديرونها بينكم فليس عليكم جناح ألا تكتبوها وأشهدوا إذا تبايعتم ولا يضار كاتب ولا شهيد وإن تفعلوا فإنه فسوق بكم واتقوا الله ويعلمكم الله والله بكل شيء عليم (282)",
	 "وإن كنتم على سفر ولم تجدوا كاتبا فرهان مقبوضة فإن أمن بعضكم بعضا فليؤد الذي اؤتمن أمانته وليتق الله ربه ولا تكتموا الشهادة ومن يكتمها فإنه آثم قلبه والله بما تعملون عليم (283)",
	 "لله ما في السماوات وما في الأرض وإن تبدوا ما في أنفسكم أو تخفوه يحاسبكم به الله فيغفر لمن يشاء ويعذب من يشاء والله على كل شيء قدير (284)",
	 "آمن الرسول بما أنزل إليه من ربه والمؤمنون كل آمن بالله وملائكته وكتبه ورسله لا نفرق بين أحد من رسله وقالوا سمعنا وأطعنا غفرانك ربنا وإليك المصير (285)",
	 "لا يكلف الله نفسا إلا وسعها لها ما كسبت وعليها ما اكتسبت ربنا لا تؤاخذنا إن نسينا أو أخطأنا ربنا ولا تحمل علينا إصرا كما حملته على الذين من قبلنا ربنا ولا تحملنا ما لا طاقة لنا به واعف عنا واغفر لنا وارحمنا أنت مولانا فانصرنا على القوم الكافرين (286)",
	 "",

        };

       // string ss = "     ";


        
        string mystring = "     ";

        public List<string> find(string nam)
        {
            List<string> arr = new List<string>();
            Parallel.ForEach<string>(ayat, (curen) => {
                if (curen.Contains(nam))
                {
                    arr.Add(curen);
                }
            });

            return arr;
        }

        public static Encoding GetFileEncoding(string srcFile)
        {
            // *** Use Default of Encoding.Default (Ansi CodePage)
            Encoding enc = Encoding.Default;

            // *** Detect byte order mark if any - otherwise assume default
            byte[] buffer = new byte[5];
            FileStream file = new FileStream(srcFile, FileMode.Open);
            file.Read(buffer, 0, 5);
            file.Close();

            if (buffer[0] == 0xef && buffer[1] == 0xbb && buffer[2] == 0xbf)
                enc = Encoding.UTF8;
            else if (buffer[0] == 0xfe && buffer[1] == 0xff)
                enc = Encoding.Unicode;
            else if (buffer[0] == 0 && buffer[1] == 0 && buffer[2] == 0xfe && buffer[3] == 0xff)
                enc = Encoding.UTF32;
            else if (buffer[0] == 0x2b && buffer[1] == 0x2f && buffer[2] == 0x76)
                enc = Encoding.UTF7;

            return enc;
        }
        public static StreamReader OpenStreamReaderWithEncoding(string srcFile)
        {
            Encoding enc = GetFileEncoding(srcFile);
            return new StreamReader(srcFile, enc);
        }
    }

      
}
