using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBud.Server.Tests
{
    internal static class OpenLibTestContent
    {
        public static string SearchTestContent = """
            { "numFound": 744,
              "start": 0,
              "numFoundExact": true,
              "num_found": 744,
              "documentation_url": "https://openlibrary.org/dev/docs/api/search",
              "q": "title:Lord of the Rings",
              "offset": null,
              "docs": [
                {
                  "author_key": [
                    "OL26320A"
                  ],
                  "author_name": [
                    "J.R.R. Tolkien"
                  ],
                  "cover_edition_key": "OL51694024M",
                  "cover_i": 14625765,
                  "ebook_access": "borrowable",
                  "edition_count": 251,
                  "first_publish_year": 1954,
                  "has_fulltext": true,
                  "ia": [
                    "lordofrings00tolk_5",
                    "yzklerinefendisi0000jrrt",
                    "hobbitguildpubli0000jrrt",
                    "lordofrings0000tolk_k7n1",
                    "lordofrings0000jrrt",
                    "lordofrings0000tolk_o3c6",
                    "lordofrings0000tolk_n6w1",
                    "osenordosaneis0000tolk",
                    "lordofrings0000tolk_d5h0",
                    "lordofrings00tolk_2",
                    "isbn_9780618343997",
                    "snj.lordofrings0000jrrt_y7c7",
                    "lordofringstrilo00jrrt",
                    "derherrderringed0000jrrt",
                    "lordofrings0000tolk_b2r2",
                    "lordofringsfello0000jrrt",
                    "isbn_9027456836",
                    "lordofringsbcaed0000jrrt",
                    "lordofrings0000tolk_y0v8",
                    "lordofrings00tolk_3",
                    "isbn_9780618640157",
                    "lordofrings00tolk_1",
                    "lordofringsonevo00jrrt",
                    "lordofrings00tolk_0"
                  ],
                  "ia_collection_s": "JaiGyan;ServantsOfKnowledge-Print;americana;bannedbooks;barryuniversity-ol;binghamton-ol;bostonpubliclibrary;bplhoughton;bpljordan-ol;cnusd-ol;cua-ol;delawarecountydistrictlibrary;inlibrary;internetarchivebooks;printdisabled;riceuniversity-ol;rochester-ol;the-claremont-colleges-ol;uiucdisabilityresources;unb-ol;uni-ol",
                  "key": "/works/OL27448W",
                  "language": [
                    "ger",
                    "eng",
                    "cat",
                    "por",
                    "jpn",
                    "rus",
                    "dut",
                    "bul",
                    "slo",
                    "ita",
                    "swe",
                    "glg",
                    "fre",
                    "cze",
                    "kor",
                    "spa",
                    "pol",
                    "tur"
                  ],
                  "lending_edition_s": "OL51711484M",
                  "lending_identifier_s": "lordofrings00tolk_5",
                  "public_scan_b": false,
                  "title": "The Lord of the Rings"
                },
                {
                  "author_key": [
                    "OL26320A"
                  ],
                  "author_name": [
                    "J.R.R. Tolkien"
                  ],
                  "cover_edition_key": "OL51708686M",
                  "cover_i": 14627060,
                  "ebook_access": "borrowable",
                  "edition_count": 296,
                  "first_publish_year": 1954,
                  "has_fulltext": true,
                  "ia": [
                    "tabinonakamaseta0000tolk",
                    "triloginomharska0000tolk",
                    "indebanvandering0000tolk",
                    "fellowshipofring00tolk_3",
                    "dereisgenoten0000tolk",
                    "leseigneurdesann0000tolk_n8i4",
                    "leseigneurdesann0000tolk_v3l9",
                    "leseigneurdesann0000tolk",
                    "leseigneurdesann0000tolk_l0f7",
                    "leseigneurdesann0000tolk_m4u0",
                    "mojiezhihuanwang0001tolk",
                    "isbn_9780007770120",
                    "ilsignoredeglian0000jrrt",
                    "isbn_9787806572504",
                    "leseigneurdesann0000fled",
                    "wadcapierscieni0000tolk",
                    "fellowshipofring0000tolk_i9r0",
                    "fellowshipofring0001tolk",
                    "fellowshipofring0000unse_q0c4",
                    "elsenordelosanil00jrrt",
                    "lacommunautedela0000jrrt",
                    "fellowshipofring0000unse_n8n1",
                    "authorizededitio00tolk",
                    "fellowshipofring0000tolk_v2u3",
                    "lccn_0345253434195",
                    "fellowshipofring00jrrt",
                    "lordofrings0000tolk_k7e8",
                    "fellowshipofring0000tolk_v0i6",
                    "fellowshipofring00tolk_0",
                    "lordofrings00jrrt",
                    "fellowshipofring0000tolk_o5y1",
                    "lordofringsco00jrrt",
                    "fellowshipofring0000tolk_a9s7",
                    "elsenordelosanil0000tolk_t3e6",
                    "mojieshoubuqumoj00tolk",
                    "lesdeuxtours0000tolk",
                    "lordofrings0000tolk_j8x1",
                    "isbn_9780965307758",
                    "lordofrings0000tolk_u6z3",
                    "fellowshipofring00tolk",
                    "fellowshipofring1973tolk",
                    "fellowshipofring01tolk",
                    "lordofrings0001tolk",
                    "lasociedadelanie0000tolk",
                    "derherrderringe0000tolk",
                    "fellowshipofring0000tolk_a6j1",
                    "lordofrings00tolk",
                    "lordofrings00tolk_4",
                    "fellowshipofringtol00tolk",
                    "fellowshipofring0000tolk",
                    "isbn_9788702347036",
                    "sociedadedoanel0000tolk",
                    "mojiexianshenfel0001tolk",
                    "lacomunidaddelan0000tolk",
                    "bwb_P8-AET-369",
                    "twotowersbeingse00tolk_0",
                    "lordofrings0000tolk_s0o3",
                    "fellowshipofring00tolkrich",
                    "fellowshipofring0001tolk_q5s5",
                    "fellowshipofring0000jrrt",
                    "fellowshipofring0000unse_l5a0",
                    "fellowshipofring0000tolk_r2o4",
                    "fellowshipofring0000tolk_s5l8",
                    "lordofringsfello0000unse",
                    "fellowshipofring0001unse",
                    "fellowshipofring0000tolk_z8w3",
                    "bwb_KS-490-629",
                    "jrrtolkienboxbox0000jrrt_c8i4",
                    "lordofrings3volu0000unse",
                    "fellowshipofring0000unse_j7u2",
                    "osenhordosanisso0000unse",
                    "fellowshipofrin00tolk"
                  ],
                  "ia_collection_s": "americana;americanuniversity-ol;bannedbooks;belmont-ol;binghamton-ol;bostonpubliclibrary;bplhoughton;cnusd-ol;cua-ol;dartmouthlibrary-ol;delawarecountydistrictlibrary;delawarecountydistrictlibrary-ol;denverpubliclibrary-ol;drakeuniversity-ol;goffstownlibrary-ol;gwulibraries-ol;hamiltonpubliclibrary-ol;inlibrary;internetarchivebooks;johnshopkins-ol;library_of_atlantis;marygrovecollege;occidentalcollegelibrary-ol;openlibrary-d-ol;popularchinesebooks;printdisabled;randolph-macon-college-ol;riceuniversity-ol;rochester-ol;tulsacc-ol;udc-ol;uhmauicollege-ol;unb-ol;uni-ol;universityofarizona-ol;universityofcoloradoboulder-ol;uslprototype;wilsoncollege-ol;worthingtonlibraries-ol",
                  "key": "/works/OL27513W",
                  "language": [
                    "ita",
                    "dut",
                    "swe",
                    "ger",
                    "ind",
                    "bul",
                    "eng",
                    "jpn",
                    "chi",
                    "ast",
                    "hrv",
                    "hun",
                    "afr",
                    "por",
                    "spa",
                    "dan",
                    "yid",
                    "fre",
                    "nor",
                    "tur",
                    "cat",
                    "pol",
                    "rus",
                    "glg"
                  ],
                  "lending_edition_s": "OL37028360M",
                  "lending_identifier_s": "tabinonakamaseta0000tolk",
                  "public_scan_b": false,
                  "title": "The Fellowship of the Ring"
                },
                {
                  "author_key": [
                    "OL26320A"
                  ],
                  "author_name": [
                    "J.R.R. Tolkien"
                  ],
                  "cover_edition_key": "OL51711454M",
                  "cover_i": 14627564,
                  "ebook_access": "borrowable",
                  "edition_count": 277,
                  "first_publish_year": 1954,
                  "has_fulltext": true,
                  "ia": [
                    "leseigneurdesann0000tolk_h4q2",
                    "triloginomharska0000tolk_r6f9",
                    "indebanvandering0000tolk_m7c6",
                    "elsenordelosanil0000tolk",
                    "dwiewieze0000tolk",
                    "twotowersbeingse00tolk_5",
                    "lesdeuxtours0002tolk",
                    "leseigneurdesann0000tolk_o9d8",
                    "leseigneurdesann0000tolk_w8u6",
                    "lesdeuxtours0000tolk_j0m4",
                    "elseordelosanill0000jrrt",
                    "twotowers0000jrrt",
                    "twotowersbeingse0000jrrt",
                    "twotowers0000jrrt_z2s3",
                    "xtwotowers50than0000jrrt",
                    "twotowerslordofr0000jrrt",
                    "twotowersbeingse0000tolk_z4n3",
                    "lordofrings3volu0000unse_l4h4",
                    "twotowersbeingse0000jrrt_d4b3",
                    "isbn_9780739478080",
                    "lordofrings2twot0000jrrt",
                    "jrrtolkienboxbox0000jrrt",
                    "bwb_P8-ATB-470",
                    "isbn_9788702347029",
                    "isbn_9788595084766",
                    "isbn_9788595084766_2",
                    "twotowersbeingse00jrrt",
                    "isbn_9782266132381",
                    "lordofrings0000tolk_j2h8",
                    "twotowersbeingse0002tolk",
                    "twotowersbeingse0000tolk_q1m5",
                    "twotowers0002tolk_r5g9",
                    "twotowersbeingse1970tolk",
                    "dietweetoringsdi0000tolk",
                    "lordofrings0000tolk_x6j5",
                    "twotowers0002unse",
                    "twotowersbeingse0002tolk_g0j1",
                    "lesdeuxtours0000tolk_g4t1",
                    "twotowersbeingse0000tolk_j4r4",
                    "twotowersbeingse0000tolk",
                    "mojieerbuqushuan00tolk_0",
                    "twotowers00jrrt_1",
                    "twotowersbeingth00tolk",
                    "twotowersbeing00tolk",
                    "twotowers00tolk",
                    "dvetverdyni0000tolk",
                    "lccn_0345253442195",
                    "twotowers0002tolk",
                    "isbn_026110232",
                    "twotowersbeingse0000tolk_p1e4",
                    "lccn_34523510x",
                    "twotowersthelord00jrrt_0",
                    "twotowers00jrrt_0",
                    "twotowersbeingse0000tolk_i0j3",
                    "twotowersbeingse2002tolk",
                    "lordofringstolk00tolk",
                    "lordofrings0000tolk_y7f8",
                    "twotowerslordoft00jrrt",
                    "lordofrings0000tolk_a0b2",
                    "lordofrings0000tolk_m2o1",
                    "elseordelosanill00jrrt_1",
                    "jrrtolkienlordof00iiunse",
                    "bwb_P8-CEP-274",
                    "shuangtaqibing0000tolk",
                    "twotowersringsuk00jrrt",
                    "derherrderringeb0000tolk",
                    "lordofrings0002tolk",
                    "lesdeuxtours0000jrrt",
                    "lordofringspt2tw0000tolk",
                    "twotowersbeingse0000tolk_z5x6",
                    "twotowersthelord00jrrt",
                    "elsenordelosanil00tolk",
                    "twotowersbeingse0000tolk_j7o8",
                    "twotowersbeingse0000tolk_a2j1",
                    "twotowersbeingse0000tolk_q2k4",
                    "twotowers0000tolk"
                  ],
                  "ia_collection_s": "americana;bannedbooks;belmont-ol;binghamton-ol;bostonpubliclibrary;bplhoughton;bpljordan-ol;cnusd-ol;danielsiders;delawarecountydistrictlibrary;delawarecountydistrictlibrary_201706;framingham-ol;inlibrary;internetarchivebookdrive;internetarchivebooks;marygrovecollege;miltonpubliclibrary-ol;openlibrary-d-ol;popularchinesebooks;printdisabled;randolph-macon-college-ol;riceuniversity-ol;rochester-ol;stmaryscountylibrary;the-claremont-colleges-ol;toronto;tulsacc-ol;unb-ol;uni-ol;universityofarizona-ol;universityofcoloradoboulder-ol;universityofthewest-ol;worthingtonlibraries-ol",
                  "key": "/works/OL27479W",
                  "language": [
                    "por",
                    "hrv",
                    "ast",
                    "cze",
                    "rus",
                    "pol",
                    "tur",
                    "afr",
                    "spa",
                    "fre",
                    "jpn",
                    "dan",
                    "dut",
                    "eng",
                    "cat",
                    "hun",
                    "bul",
                    "swe",
                    "chi",
                    "ger",
                    "yid",
                    "ind",
                    "baq",
                    "ita"
                  ],
                  "lending_edition_s": "OL43511705M",
                  "lending_identifier_s": "leseigneurdesann0000tolk_h4q2",
                  "public_scan_b": false,
                  "title": "The Two Towers"
                },
                {
                  "author_key": [
                    "OL26320A"
                  ],
                  "author_name": [
                    "J.R.R. Tolkien"
                  ],
                  "cover_edition_key": "OL51708706M",
                  "cover_i": 14627062,
                  "ebook_access": "borrowable",
                  "edition_count": 271,
                  "first_publish_year": 1950,
                  "has_fulltext": true,
                  "ia": [
                    "leretourduroi0000jrrt",
                    "elsenordelosanil0003tolk",
                    "osenhordosanisor0000unse",
                    "leseigneurdesann0000tolk_e6i0",
                    "leseigneurdesann0000tolk_k6z7",
                    "powrotkrola0000tolk",
                    "leretourduroiles00jrrt",
                    "isbn_9788595084773",
                    "elretornodelrey0000tolk",
                    "lccn_0345253450195",
                    "elseordelosanill0000jrrt_n4m9",
                    "returnofking0000tolk_t1r7",
                    "mojiesanbuquwang0000tolk",
                    "returnofkingbe00tolk",
                    "returnofkingbeintolk00tolk",
                    "returnofkingbein03tolk",
                    "returnofkingbein1965tolk",
                    "returnofkingbeintol00tolk",
                    "returnofkingbein00tolk_0",
                    "returnofking00tolk",
                    "returnoftheking0000unse",
                    "returnofking03tolk",
                    "returnofkingbein0000tolk_r5w8",
                    "returnofkingbein00tolk_1",
                    "returnofkingbein0000tolk",
                    "returnofking0003unse",
                    "lordofrings56tolk",
                    "returnofkingbein1994tolk",
                    "lordofringspartt00jrrt",
                    "returnofking00tolk_0",
                    "lordofring00tolk",
                    "leretourduroi00jrrt",
                    "returnofkingthel00jrrt",
                    "returnofkingbein0003tolk",
                    "yuzuklerinefendi0000tolk",
                    "returnofkingthel00jrrt_0",
                    "leretourduroi0000tolk",
                    "wangzhewudi0000tolk",
                    "returnofking00jrrt_2",
                    "elretornodelrey0000jrrt",
                    "returnofkingbein0000tolk_j1m4",
                    "returnofkingbeintolkien00tolk",
                    "returnofkingbeintolkie00tolk",
                    "lordofrings0000tolk_d6c9",
                    "lccn_345235118125",
                    "mojiexianshenfel0003tolk",
                    "lordofrings0003tolk",
                    "lordofrings5hard00jrrt",
                    "returnofkingbein1993tolk",
                    "returnofking0000tolk_r4w6",
                    "panprstenov0000tolk",
                    "lordofrings0000tolk_n6x8",
                    "returnofkingbein0000tolk_e4y6",
                    "returnofkingbein0000tolk_w4t4",
                    "returnofking0000tolk",
                    "returnofkingbein0000tolk_l8w2",
                    "lordofringsretur0000jrrt",
                    "returnofkingbein0003tolk_m6s4",
                    "returnofkingbei00tolk",
                    "returnofking00tolk_1",
                    "returnofking00jrrt",
                    "lccn_345247868100",
                    "lordofrings0000tolk",
                    "isbn_9788595084773_q6a3",
                    "returnofkingbein0000tolk_p3y3",
                    "lordofrings0000tolk_i6c9",
                    "returnofking0000jrrt",
                    "returnofking0000jrrt_f3k1",
                    "returnofking0000jrrt_k3d3",
                    "returnofking0000jrrt_n9b7",
                    "returnofking0000jrrt_y6p0",
                    "returnofkingtolk00tolk",
                    "isbn_9782266132398_3",
                    "lordofrings0000tolk_r3e9",
                    "isbn_034533938",
                    "returnofking0000jrrt_r6w9",
                    "isbn_9780329278052",
                    "returnofking0000tolk_y5o9",
                    "returnofking0000jrrt_i6m3",
                    "jrrtolkienboxbox0000jrrt_z4a7",
                    "lordofrings3volu0000unse_k1e5",
                    "heerservandierin0000jrrt"
                  ],
                  "ia_collection_s": "americana;bannedbooks;bpljordan-ol;cnusd-ol;danielsiders;delawarecountydistrictlibrary;drakeuniversity-ol;gwulibraries-ol;hamiltonpubliclibrary-ol;inlibrary;internetarchivebookdrive;internetarchivebooks;johnshopkins-ol;library_of_atlantis;marygrovecollege;miltonpubliclibrary-ol;openlibrary-d-ol;popularchinesebooks;printdisabled;riceuniversity-ol;rochester-ol;stmaryscountylibrary;tulsacc-ol;unb-ol",
                  "key": "/works/OL27455W",
                  "language": [
                    "por",
                    "hrv",
                    "rus",
                    "cze",
                    "vie",
                    "pol",
                    "tur",
                    "afr",
                    "spa",
                    "fre",
                    "dut",
                    "eng",
                    "cat",
                    "slo",
                    "bul",
                    "gre",
                    "chi",
                    "ger",
                    "srp",
                    "kor",
                    "yid",
                    "ind",
                    "baq",
                    "ita"
                  ],
                  "lending_edition_s": "OL8889880M",
                  "lending_identifier_s": "leretourduroi0000jrrt",
                  "public_scan_b": false,
                  "title": "The Return of the King"
                },
                {
                  "author_key": [
                    "OL26320A"
                  ],
                  "author_name": [
                    "J.R.R. Tolkien"
                  ],
                  "cover_edition_key": "OL51711263M",
                  "cover_i": 14627509,
                  "ebook_access": "borrowable",
                  "edition_count": 458,
                  "first_publish_year": 1937,
                  "has_fulltext": true,
                  "ia": [
                    "hobbitortherebac00tolk_2",
                    "annotatedhobbith00tolk_0",
                    "hobbitalbotamizp0000tolk",
                    "derkleinehobbit0000tolk",
                    "elhobbitohistori0000tolk_c5o2",
                    "chatcuanhungchic0000tolk",
                    "elhobbitohistori0000tolk",
                    "bilboenhobbitsav0000tolk",
                    "hobbitortherebac0000tolk_g4l2",
                    "dehobbit0000tolk",
                    "hobbitczylitamiz0000tolk",
                    "elhobbit0000tolk",
                    "bilbolehobbit0000tolk_p8p7",
                    "hobbitenchanting0000jrrt",
                    "bilbolehobbit0000jrrt",
                    "derhobitoderahin0000jrrt",
                    "vlastelinkolets0000tolk_w7m9",
                    "isbn_9788595086081",
                    "kahopitaioleilai0000tolk",
                    "isbn_9780547928227",
                    "hobbitortherebc00tolk",
                    "hobbitortherebac0000tolk_s7i1",
                    "lehobbit0000tolk",
                    "hobbit0000tolk",
                    "hobbit00jrrt",
                    "hobbitortherebac0000tolk",
                    "hobbitortherebac0000tolk_n8h0",
                    "huobiterenquerfu0000tolk",
                    "hobbit0000tolk_d7o7",
                    "elhobbit00jrrt",
                    "bilbolehobbit0000tolk_h6b2",
                    "hobbitortherebac00tolk_0",
                    "hobbitortherebac0000tolk_c1w4",
                    "mojieqianzhuanhu0000tolk",
                    "mojieqianzhuanha00tolk",
                    "hobbitpart2tolk",
                    "annotatedhobbith0000tolk",
                    "snj.hobbitortherebac0000tolk_d7v1",
                    "bilbolehobbit0000tolk_z5o6",
                    "hobbitortherebla0000jrrt",
                    "khobbitilitudaio0000tolk",
                    "hobbitortherebac00tolk",
                    "hobbitortherebactolk00tolk",
                    "hobbitortherebac0000tolk_b5p9",
                    "hobbitortherebac0000tolk_b9p5",
                    "hobbitorthereand00tolk",
                    "dehobbit0000tolk_h5i8",
                    "lohobbitolaricon0000tolk",
                    "isbn_9788595084742",
                    "elhobbit0000jrrt",
                    "hobbitczylitamiz0000tolk_r8i7",
                    "hobbitczylitamiz0000tolk_r8i7",
                    "derhobbitoderhin0000tolk",
                    "derkleinehobbit0000jrrt",
                    "bilbolehobbit0000tolk_s8c3",
                    "isbn_9782013235327",
                    "bilbolehobbit0000jrrt_t2a7",
                    "bilbolehobbittex0000jrrt",
                    "bilbolehobbitfre0000jrrt",
                    "annotatedhobbith00tolk",
                    "hobbit0000jrrt_d9x3",
                    "hobbit0000jrrt_j8p8",
                    "hobbit00jrrt_1",
                    "hobbit0000jrrt_i7m0",
                    "hobbitortherebac0000tolk_b6i8",
                    "hobbitortherebactolk",
                    "hobbitjrrt00jrrt",
                    "lccn_0345253426195",
                    "lccn_345248260175",
                    "hobbitortherebac0000tolk_c9d1",
                    "hobbit0000jrrt_n0j5",
                    "hobbit0000tolk_o9y4",
                    "hobbit0000tolk_r0y9",
                    "hobbit0000jrrt_l2o3",
                    "hobbitortherebac0000jrrt",
                    "bwb_P8-CED-692",
                    "hobbitortherebac0000jrrt_n7e5",
                    "bwb_W7-BSZ-467",
                    "hobbit0000jrrt",
                    "hobbit0000jrrt_n0s0",
                    "hobbitortherebac0000tolk_a2n1",
                    "hobbitortherebac0000tolk_t0g2",
                    "hobbitortherebac0000tolk_y8a9",
                    "hobbitortherebac0000tolk_x2n1",
                    "hobbitortherebac00tolk_1"
                  ],
                  "ia_collection_s": "JaiGyan;ServantsOfKnowledge-Print;americana;americanuniversity-ol;belmont-ol;binghamton-ol;bostonpubliclibrary;bplhoughton;bpljordan-ol;cnusd-ol;cua-ol;danielsiders;dartmouthlibrary-ol;delawarecountydistrictlibrary;delawarecountydistrictlibrary-ol;denverpubliclibrary-ol;drakeuniversity-ol;framingham-ol;goffstownlibrary-ol;gwulibraries-ol;hamiltonpubliclibrary-ol;inlibrary;internetarchivebookdrive;internetarchivebooks;ithacacollege-ol;kalamazoocollege-ol;marymount-ol;occidentalcollegelibrary-ol;openlibrary-d-ol;popularchinesebooks;printdisabled;randolph-macon-college-ol;rochester-ol;salisburyfreelibrary-ol;schroederlibrary-ol;spokanepubliclibrary-ol;the-claremont-colleges-ol;tulsacc-ol;udc-ol;unb-ol;uni-ol;universityofarizona-ol;universityofcoloradoboulder-ol;universityofoklahoma-ol;wilsoncollege-ol;worthingtonlibraries-ol",
                  "key": "/works/OL27482W",
                  "language": [
                    "por",
                    "rus",
                    "cze",
                    "vie",
                    "pol",
                    "tur",
                    "fin",
                    "lat",
                    "spa",
                    "fre",
                    "jpn",
                    "dan",
                    "dut",
                    "epo",
                    "eng",
                    "cat",
                    "bul",
                    "swe",
                    "rum",
                    "ang",
                    "nob",
                    "bre",
                    "chi",
                    "ger",
                    "cor",
                    "heb",
                    "yid",
                    "ita",
                    "gle",
                    "lez"
                  ],
                  "lending_edition_s": "OL51709286M",
                  "lending_identifier_s": "hobbitortherebac00tolk_2",
                  "public_scan_b": false,
                  "title": "The Hobbit"
                },
                {
                  "author_key": [
                    "OL8354734A"
                  ],
                  "author_name": [
                    "SuperSummary"
                  ],
                  "cover_edition_key": "OL35659077M",
                  "cover_i": 12366237,
                  "ebook_access": "no_ebook",
                  "edition_count": 619,
                  "first_publish_year": 2017,
                  "has_fulltext": false,
                  "key": "/works/OL21868175W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Study Guide"
                },
                {
                  "author_key": [
                    "OL232748A",
                    "OL2689079A",
                    "OL2725410A",
                    "OL27452A",
                    "OL9100884A"
                  ],
                  "author_name": [
                    "Henry Beard",
                    "Harvard Lampoon",
                    "Douglas C. Kenney",
                    "Jean Little",
                    "Jim Meskimen"
                  ],
                  "cover_edition_key": "OL7878776M",
                  "cover_i": 380223,
                  "ebook_access": "borrowable",
                  "edition_count": 26,
                  "first_publish_year": 1969,
                  "has_fulltext": true,
                  "ia": [
                    "boredofrings0000unse",
                    "boredofringsparo0000bear",
                    "isbn_0451126548",
                    "boredofringsparo0000bear_f9s1",
                    "boredofringsparo00harv",
                    "boredofringsparobear00bear"
                  ],
                  "ia_collection_s": "americana;inlibrary;internetarchivebooks;openlibrary-d-ol;printdisabled",
                  "key": "/works/OL1939708W",
                  "language": [
                    "eng",
                    "fin"
                  ],
                  "lending_edition_s": "OL7878776M",
                  "lending_identifier_s": "boredofrings0000unse",
                  "public_scan_b": false,
                  "title": "Bored of the Rings"
                },
                {
                  "author_key": [
                    "OL26320A"
                  ],
                  "author_name": [
                    "J.R.R. Tolkien"
                  ],
                  "cover_edition_key": "OL7466533M",
                  "cover_i": 255844,
                  "ebook_access": "no_ebook",
                  "edition_count": 24,
                  "first_publish_year": 1979,
                  "has_fulltext": false,
                  "key": "/works/OL14926019W",
                  "language": [
                    "rus",
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Novels (Hobbit / Lord of the Rings)"
                },
                {
                  "author_key": [
                    "OL26320A",
                    "OL2623360A"
                  ],
                  "author_name": [
                    "J.R.R. Tolkien",
                    "Christopher Tolkien"
                  ],
                  "cover_edition_key": "OL7603614M",
                  "cover_i": 14625634,
                  "ebook_access": "printdisabled",
                  "edition_count": 15,
                  "first_publish_year": 1990,
                  "has_fulltext": true,
                  "ia": [
                    "warofring0000tolk"
                  ],
                  "ia_collection_s": "binghamton-ol;cnusd-ol;dartmouthlibrary-ol;hamiltonpubliclibrary-ol;internetarchivebooks;johnshopkins-ol;openlibrary-d-ol;printdisabled;rochester-ol;the-claremont-colleges-ol;unb-ol;uni-ol;universityofarizona-ol;universityofoklahoma-ol",
                  "key": "/works/OL27491W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "The War of the Ring"
                },
                {
                  "author_key": [
                    "OL26320A"
                  ],
                  "author_name": [
                    "J.R.R. Tolkien"
                  ],
                  "cover_i": 8220055,
                  "ebook_access": "borrowable",
                  "edition_count": 14,
                  "first_publish_year": 1988,
                  "has_fulltext": true,
                  "ia": [
                    "returnofshadowhi0000tolk",
                    "returnofshadow00tolk"
                  ],
                  "ia_collection_s": "americana;bannedbooks;delawarecountydistrictlibrary;inlibrary;internetarchivebooks;printdisabled",
                  "key": "/works/OL27508W",
                  "language": [
                    "eng",
                    "spa"
                  ],
                  "lending_edition_s": "OL22855921M",
                  "lending_identifier_s": "returnofshadowhi0000tolk",
                  "public_scan_b": false,
                  "title": "The Return of the Shadow"
                },
                {
                  "author_key": [
                    "OL475982A"
                  ],
                  "author_name": [
                    "Brian Sibley"
                  ],
                  "cover_edition_key": "OL3953584M",
                  "cover_i": 393721,
                  "ebook_access": "borrowable",
                  "edition_count": 3,
                  "first_publish_year": 2001,
                  "has_fulltext": true,
                  "ia": [
                    "lordofringsmakin00sibl",
                    "lordofringsinsid00sibl"
                  ],
                  "ia_collection_s": "belmont-ol;binghamton-ol;cnusd-ol;inlibrary;internetarchivebooks;openlibrary-d-ol;printdisabled;stmaryscountylibrary",
                  "key": "/works/OL3062799W",
                  "language": [
                    "eng"
                  ],
                  "lending_edition_s": "OL23247000M",
                  "lending_identifier_s": "lordofringsmakin00sibl",
                  "public_scan_b": false,
                  "title": "The lord of the rings"
                },
                {
                  "author_key": [
                    "OL10419422A"
                  ],
                  "author_name": [
                    "Kellie WILSON"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 89,
                  "first_publish_year": 2022,
                  "has_fulltext": false,
                  "key": "/works/OL27922588W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Baby Sitter Information"
                },
                {
                  "author_key": [
                    "OL257300A",
                    "OL1194589A"
                  ],
                  "author_name": [
                    "Phil Anderson",
                    "Philip A. Anderson"
                  ],
                  "cover_edition_key": "OL8184572M",
                  "cover_i": 1576186,
                  "ebook_access": "borrowable",
                  "edition_count": 3,
                  "first_publish_year": 2006,
                  "has_fulltext": true,
                  "ia": [
                    "lordofring0000ande"
                  ],
                  "ia_collection_s": "inlibrary;internetarchivebooks;printdisabled",
                  "key": "/works/OL2089932W",
                  "language": [
                    "eng"
                  ],
                  "lending_edition_s": "OL8184572M",
                  "lending_identifier_s": "lordofring0000ande",
                  "public_scan_b": false,
                  "title": "The Lord of the Ring"
                },
                {
                  "author_key": [
                    "OL2853379A"
                  ],
                  "author_name": [
                    "Cedco Publishing"
                  ],
                  "cover_edition_key": "OL9701406M",
                  "cover_i": 1454705,
                  "ebook_access": "no_ebook",
                  "edition_count": 5,
                  "first_publish_year": 2001,
                  "has_fulltext": false,
                  "key": "/works/OL8527426W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Lord of the Rings"
                },
                {
                  "author_key": [
                    "OL1399851A"
                  ],
                  "author_name": [
                    "Jude Fisher"
                  ],
                  "cover_edition_key": "OL3670507M",
                  "cover_i": 393983,
                  "ebook_access": "borrowable",
                  "edition_count": 3,
                  "first_publish_year": 2001,
                  "has_fulltext": true,
                  "ia": [
                    "lordofringsfello00fish"
                  ],
                  "ia_collection_s": "bpljordan-ol;inlibrary;internetarchivebooks;printdisabled",
                  "key": "/works/OL5753836W",
                  "language": [
                    "eng"
                  ],
                  "lending_edition_s": "OL3949131M",
                  "lending_identifier_s": "lordofringsfello00fish",
                  "public_scan_b": false,
                  "title": "The lord of the rings"
                },
                {
                  "author_key": [
                    "OL2834626A"
                  ],
                  "author_name": [
                    "Howard Shore"
                  ],
                  "cover_i": 505156,
                  "ebook_access": "printdisabled",
                  "edition_count": 1,
                  "first_publish_year": 2002,
                  "has_fulltext": true,
                  "ia": [
                    "fellowshipofring00enya"
                  ],
                  "ia_collection_s": "internetarchivebooks;ithacacollege-ol;openlibrary-d-ol;printdisabled",
                  "key": "/works/OL8238812W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "The Fellowship of the Ring"
                },
                {
                  "author_key": [
                    "OL26320A",
                    "OL2623360A"
                  ],
                  "author_name": [
                    "J.R.R. Tolkien",
                    "Christopher Tolkien"
                  ],
                  "cover_i": 8220122,
                  "ebook_access": "printdisabled",
                  "edition_count": 13,
                  "first_publish_year": 1989,
                  "has_fulltext": true,
                  "ia": [
                    "treasonofisengar0000tolk",
                    "isbn_9780395515624"
                  ],
                  "ia_collection_s": "binghamton-ol;bostonuniversitylibraries-ol;dartmouthlibrary-ol;denverpubliclibrary-ol;gwulibraries-ol;internetarchivebooks;printdisabled;riceuniversity-ol;rochester-ol;the-claremont-colleges-ol;unb-ol;uni-ol;universityofcoloradoboulder-ol;universityofoklahoma-ol;wrlc-ol",
                  "key": "/works/OL27478W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "The Treason of Isengard"
                },
                {
                  "author_key": [
                    "OL5470710A"
                  ],
                  "author_name": [
                    "Jim Pendrill"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "has_fulltext": false,
                  "key": "/works/OL12413029W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Lord of the rings"
                },
                {
                  "author_key": [
                    "OL26320A"
                  ],
                  "author_name": [
                    "J.R.R. Tolkien"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2024,
                  "has_fulltext": false,
                  "key": "/works/OL42558748W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Lord of the Rings"
                },
                {
                  "author_key": [
                    "OL883989A"
                  ],
                  "author_name": [
                    "Alison Sage"
                  ],
                  "cover_edition_key": "OL3953527M",
                  "cover_i": 393720,
                  "ebook_access": "borrowable",
                  "edition_count": 4,
                  "first_publish_year": 2001,
                  "has_fulltext": true,
                  "ia": [
                    "lordofringsfello00sage",
                    "lordofringstrilo0000sage"
                  ],
                  "ia_collection_s": "inlibrary;internetarchivebooks;openlibrary-d-ol;printdisabled",
                  "key": "/works/OL4442132W",
                  "language": [
                    "eng"
                  ],
                  "lending_edition_s": "OL3953527M",
                  "lending_identifier_s": "lordofringsfello00sage",
                  "public_scan_b": false,
                  "title": "The Lord of the Rings The Fellowship of the Ring Photo Guide"
                },
                {
                  "author_key": [
                    "OL2703716A"
                  ],
                  "author_name": [
                    "Tania Cox"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2020,
                  "has_fulltext": false,
                  "key": "/works/OL27563121W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Lord of the Rings the Fellowship of the Ring"
                },
                {
                  "author_key": [
                    "OL29809A"
                  ],
                  "author_name": [
                    "Harold Bloom"
                  ],
                  "cover_edition_key": "OL8159083M",
                  "cover_i": 555542,
                  "ebook_access": "borrowable",
                  "edition_count": 3,
                  "first_publish_year": 2000,
                  "has_fulltext": true,
                  "ia": [
                    "jrrtolkienslord00bloo"
                  ],
                  "ia_collection_s": "binghamton-ol;bpljordan-ol;cnusd-ol;inlibrary;internetarchivebooks;johnshopkins-ol;printdisabled;riceuniversity-ol;rochester-ol;stmaryscountylibrary",
                  "key": "/works/OL14933408W",
                  "language": [
                    "eng"
                  ],
                  "lending_edition_s": "OL49430M",
                  "lending_identifier_s": "jrrtolkienslord00bloo",
                  "public_scan_b": false,
                  "title": "J. R. R. Tolkien's The Lord of the Rings"
                },
                {
                  "author_key": [
                    "OL26320A"
                  ],
                  "author_name": [
                    "J.R.R. Tolkien"
                  ],
                  "cover_edition_key": "OL9131861M",
                  "cover_i": 8406792,
                  "ebook_access": "printdisabled",
                  "edition_count": 9,
                  "first_publish_year": 1999,
                  "has_fulltext": true,
                  "ia": [
                    "elseordelosanill00jrrt_0",
                    "isbn_9783608987027"
                  ],
                  "ia_collection_s": "bannedbooks;internetarchivebooks;printdisabled",
                  "key": "/works/OL27438W",
                  "language": [
                    "spa",
                    "eng",
                    "ger"
                  ],
                  "public_scan_b": false,
                  "title": "The Lord of the Rings. Appendices"
                },
                {
                  "author_key": [
                    "OL1813446A",
                    "OL3259719A"
                  ],
                  "author_name": [
                    "Lin Carter",
                    "Lyn Carter"
                  ],
                  "cover_edition_key": "OL8942947M",
                  "cover_i": 988471,
                  "ebook_access": "borrowable",
                  "edition_count": 14,
                  "first_publish_year": 1969,
                  "has_fulltext": true,
                  "ia": [
                    "tolkienlookbehin00cartrich",
                    "tolkienlookbehin00cart",
                    "tolkienlookbehin0000cart",
                    "tolkien0000linc",
                    "tolkien01cart"
                  ],
                  "ia_collection_s": "americana;clean_list;duke_libraries;inlibrary;internetarchivebooks;printdisabled;rochester-ol",
                  "key": "/works/OL6704339W",
                  "language": [
                    "eng",
                    "spa"
                  ],
                  "lending_edition_s": "OL24222113M",
                  "lending_identifier_s": "tolkienlookbehin00cartrich",
                  "public_scan_b": false,
                  "subtitle": "A Look Behind the Lord of the Rings",
                  "title": "Tolkien"
                },
                {
                  "author_key": [
                    "OL4229287A",
                    "OL7528704A",
                    "OL7529094A"
                  ],
                  "author_name": [
                    "Liv Tyler",
                    "Cate Blanchett",
                    "Peter Jackson"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2002,
                  "has_fulltext": false,
                  "key": "/works/OL28758970W",
                  "public_scan_b": false,
                  "title": "The Lord of the Rings"
                },
                {
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "has_fulltext": false,
                  "key": "/works/OL39009766W",
                  "public_scan_b": false,
                  "title": "The Lord of the Rings"
                },
                {
                  "author_key": [
                    "OL2858510A"
                  ],
                  "author_name": [
                    "Elijah Wood"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "has_fulltext": false,
                  "key": "/works/OL33918153W",
                  "public_scan_b": false,
                  "title": "The Lord of the Rings"
                },
                {
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2012,
                  "has_fulltext": false,
                  "key": "/works/OL33733658W",
                  "public_scan_b": false,
                  "title": "The Lord of the Rings"
                },
                {
                  "author_key": [
                    "OL7442781A",
                    "OL26165A"
                  ],
                  "author_name": [
                    "Chris Conkling",
                    "Peter S. Beagle"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 1979,
                  "has_fulltext": false,
                  "key": "/works/OL18146933W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "The Lord of the Rings"
                },
                {
                  "author_key": [
                    "OL10182808A"
                  ],
                  "author_name": [
                    "Raffaello De Siati"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2020,
                  "has_fulltext": false,
                  "key": "/works/OL27169719W",
                  "language": [
                    "ita"
                  ],
                  "public_scan_b": false,
                  "title": "Lord of the Rings the Fellowship of the Ring"
                },
                {
                  "author_key": [
                    "OL2821360A",
                    "OL1605109A",
                    "OL244984A"
                  ],
                  "author_name": [
                    "Mark Cohen",
                    "Debra McBride",
                    "David Cassady"
                  ],
                  "cover_edition_key": "OL8018275M",
                  "cover_i": 8167590,
                  "ebook_access": "borrowable",
                  "edition_count": 1,
                  "first_publish_year": 2002,
                  "has_fulltext": true,
                  "ia": [
                    "lordofringsfello0000cass"
                  ],
                  "ia_collection_s": "inlibrary;internetarchivebooks;printdisabled",
                  "key": "/works/OL17863428W",
                  "language": [
                    "eng"
                  ],
                  "lending_edition_s": "OL8018275M",
                  "lending_identifier_s": "lordofringsfello0000cass",
                  "public_scan_b": false,
                  "subtitle": "The Fellowship of the Ring",
                  "title": "The Lord of the Rings"
                },
                {
                  "author_key": [
                    "OL578238A",
                    "OL7798802A"
                  ],
                  "author_name": [
                    "Jane Chance",
                    "Jane Chance"
                  ],
                  "cover_edition_key": "OL1700996M",
                  "cover_i": 583487,
                  "ebook_access": "borrowable",
                  "edition_count": 5,
                  "first_publish_year": 1992,
                  "has_fulltext": true,
                  "ia": [
                    "lordofringst00chan",
                    "isbn_9780813190174"
                  ],
                  "ia_collection_s": "binghamton-ol;dartmouthlibrary-ol;gwulibraries-ol;inlibrary;internetarchivebooks;printdisabled;randolph-macon-college-ol;riceuniversity-ol;rochester-ol;the-claremont-colleges-ol;uni-ol;universityofarizona-ol;universityofcoloradoboulder-ol;universityofoklahoma-ol",
                  "key": "/works/OL3469307W",
                  "language": [
                    "eng"
                  ],
                  "lending_edition_s": "OL1700996M",
                  "lending_identifier_s": "lordofringst00chan",
                  "public_scan_b": false,
                  "title": "The Lord of the Rings"
                },
                {
                  "author_key": [
                    "OL39015A",
                    "OL2623691A"
                  ],
                  "author_name": [
                    "Wayne G. Hammond",
                    "Christina Scull"
                  ],
                  "cover_edition_key": "OL3410671M",
                  "cover_i": 395072,
                  "ebook_access": "borrowable",
                  "edition_count": 4,
                  "first_publish_year": 2005,
                  "has_fulltext": true,
                  "ia": [
                    "lordofringsreade0000hamm"
                  ],
                  "ia_collection_s": "inlibrary;internetarchivebooks;printdisabled",
                  "key": "/works/OL548432W",
                  "language": [
                    "eng"
                  ],
                  "lending_edition_s": "OL26236285M",
                  "lending_identifier_s": "lordofringsreade0000hamm",
                  "public_scan_b": false,
                  "subtitle": "A Reader's Companion",
                  "title": "The lord of the rings"
                },
                {
                  "author_key": [
                    "OL2853379A"
                  ],
                  "author_name": [
                    "Cedco Publishing"
                  ],
                  "cover_edition_key": "OL8065489M",
                  "cover_i": 528861,
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2002,
                  "has_fulltext": false,
                  "key": "/works/OL8527355W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "The Lord of the Rings, Fellowship of the Ring 2003 Daily Calendar (Lord of the Rings)"
                },
                {
                  "author_key": [
                    "OL6439810A"
                  ],
                  "author_name": [
                    "Fran Walsh"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 2,
                  "first_publish_year": 2002,
                  "has_fulltext": false,
                  "key": "/works/OL13578274W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "The lord of the rings"
                },
                {
                  "author_key": [
                    "OL14008371A"
                  ],
                  "author_name": [
                    "J. R. R. Tolkien"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 3,
                  "first_publish_year": 1961,
                  "has_fulltext": false,
                  "key": "/works/OL42503471W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "The Fellowship of the Ring"
                },
                {
                  "author_key": [
                    "OL2853379A"
                  ],
                  "author_name": [
                    "Cedco Publishing"
                  ],
                  "cover_edition_key": "OL8065495M",
                  "cover_i": 528867,
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2004,
                  "has_fulltext": false,
                  "key": "/works/OL34315353W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "The Lord of the Rings Trilogy"
                },
                {
                  "author_key": [
                    "OL5676501A"
                  ],
                  "author_name": [
                    "Ian Brodie"
                  ],
                  "cover_edition_key": "OL21992239M",
                  "cover_i": 11406366,
                  "ebook_access": "borrowable",
                  "edition_count": 5,
                  "first_publish_year": 2002,
                  "has_fulltext": true,
                  "ia": [
                    "lordofringslocat0000brod"
                  ],
                  "ia_collection_s": "inlibrary;internetarchivebooks;printdisabled",
                  "key": "/works/OL12693815W",
                  "language": [
                    "eng"
                  ],
                  "lending_edition_s": "OL21992239M",
                  "lending_identifier_s": "lordofringslocat0000brod",
                  "public_scan_b": false,
                  "title": "The Lord of the rings location guidebook"
                },
                {
                  "author_key": [
                    "OL2821360A"
                  ],
                  "author_name": [
                    "Mark Cohen"
                  ],
                  "cover_edition_key": "OL7953556M",
                  "cover_i": 481575,
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2003,
                  "has_fulltext": false,
                  "key": "/works/OL8456214W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "The Lord of the Rings - War of the Ring"
                },
                {
                  "author_key": [
                    "OL232901A"
                  ],
                  "author_name": [
                    "Bruce Blackadar"
                  ],
                  "cover_edition_key": "OL11445939M",
                  "cover_i": 13340334,
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 1987,
                  "has_fulltext": false,
                  "key": "/works/OL20652017W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Lords of the Ring"
                },
                {
                  "author_key": [
                    "OL26320A"
                  ],
                  "author_name": [
                    "J.R.R. Tolkien"
                  ],
                  "cover_edition_key": "OL17345578M",
                  "cover_i": 10564282,
                  "ebook_access": "borrowable",
                  "edition_count": 8,
                  "first_publish_year": 1987,
                  "has_fulltext": true,
                  "ia": [
                    "lostroadotherwri0000tolk",
                    "lostroadotherwri00jrrt"
                  ],
                  "ia_collection_s": "inlibrary;internetarchivebooks;printdisabled",
                  "key": "/works/OL27485W",
                  "language": [
                    "eng"
                  ],
                  "lending_edition_s": "OL17345578M",
                  "lending_identifier_s": "lostroadotherwri0000tolk",
                  "public_scan_b": false,
                  "title": "The lost road and other writings"
                },
                {
                  "author_key": [
                    "OL2838384A"
                  ],
                  "author_name": [
                    "Prima Development"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2002,
                  "has_fulltext": false,
                  "key": "/works/OL8495600W",
                  "public_scan_b": false,
                  "title": "The \"Lord of the Rings - The Fellowship of the Rings\""
                },
                {
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "has_fulltext": false,
                  "key": "/works/OL31711215W",
                  "public_scan_b": false,
                  "title": "Lord of the Rings"
                },
                {
                  "author_key": [
                    "OL475982A"
                  ],
                  "author_name": [
                    "Brian Sibley"
                  ],
                  "cover_edition_key": "OL24212888M",
                  "cover_i": 6532865,
                  "ebook_access": "borrowable",
                  "edition_count": 1,
                  "first_publish_year": 2001,
                  "has_fulltext": true,
                  "ia": [
                    "lordofringsfello00siblrich"
                  ],
                  "ia_collection_s": "americana;inlibrary;internetarchivebooks;openlibrary-d-ol;printdisabled",
                  "key": "/works/OL15145356W",
                  "lending_edition_s": "OL24212888M",
                  "lending_identifier_s": "lordofringsfello00siblrich",
                  "public_scan_b": false,
                  "subtitle": "the fellowship of the ring ; insiders' guide",
                  "title": "The Lord of the rings"
                },
                {
                  "author_key": [
                    "OL1391622A"
                  ],
                  "author_name": [
                    "Stratford Caldecott"
                  ],
                  "cover_edition_key": "OL3299826M",
                  "cover_i": 626422,
                  "ebook_access": "borrowable",
                  "edition_count": 5,
                  "first_publish_year": 2005,
                  "has_fulltext": true,
                  "ia": [
                    "powerofringspiri0000cald"
                  ],
                  "ia_collection_s": "americanuniversity-ol;binghamton-ol;cua-ol;gwulibraries-ol;hamiltonpubliclibrary-ol;inlibrary;internetarchivebooks;johnshopkins-ol;printdisabled;rochester-ol;universityofarizona-ol;universityofcoloradoboulder-ol;wilsoncollege-ol",
                  "key": "/works/OL5722225W",
                  "language": [
                    "eng"
                  ],
                  "lending_edition_s": "OL3299826M",
                  "lending_identifier_s": "powerofringspiri0000cald",
                  "public_scan_b": false,
                  "subtitle": "the spiritual vision behind The lord of the rings",
                  "title": "The power of the ring"
                },
                {
                  "author_key": [
                    "OL2838674A"
                  ],
                  "author_name": [
                    "Scruffy Productions"
                  ],
                  "cover_edition_key": "OL10905390M",
                  "cover_i": 2605854,
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2002,
                  "has_fulltext": false,
                  "key": "/works/OL8496085W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "The Lord of the Rings - The Fellowship of the Ring"
                },
                {
                  "cover_i": 8456479,
                  "ebook_access": "no_ebook",
                  "edition_count": 0,
                  "has_fulltext": false,
                  "key": "/works/OL19342810W",
                  "public_scan_b": false,
                  "title": "The Lord of the Rings: The Fellowship of the Ring"
                },
                {
                  "author_key": [
                    "OL1548947A",
                    "OL2710568A",
                    "OL7486939A",
                    "OL7618980A"
                  ],
                  "author_name": [
                    "William Bernard Ready",
                    "William Ready",
                    "William Bernard Ready",
                    "William ready"
                  ],
                  "cover_edition_key": "OL24939545M",
                  "cover_i": 6924975,
                  "ebook_access": "borrowable",
                  "edition_count": 13,
                  "first_publish_year": 1968,
                  "has_fulltext": true,
                  "ia": [
                    "tolkienrelationp00read",
                    "tolkienrelation0000read",
                    "understandingtol00read",
                    "bwb_Y0-AFU-877"
                  ],
                  "ia_collection_s": "inlibrary;internetarchivebooks;printdisabled",
                  "key": "/works/OL6090504W",
                  "language": [
                    "eng"
                  ],
                  "lending_edition_s": "OL5610559M",
                  "lending_identifier_s": "tolkienrelationp00read",
                  "public_scan_b": false,
                  "title": "The Tolkien Relation"
                },
                {
                  "author_key": [
                    "OL13524430A"
                  ],
                  "author_name": [
                    "BookCaps Study Guides Staff"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2012,
                  "has_fulltext": false,
                  "key": "/works/OL39927782W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Lord of the Rings Companion"
                },
                {
                  "author_key": [
                    "OL3399247A",
                    "OL3399248A"
                  ],
                  "author_name": [
                    "Harry Lansdown",
                    "Alex Spillius"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 2,
                  "first_publish_year": 1991,
                  "has_fulltext": false,
                  "key": "/works/OL9356256W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Lords of the ring"
                },
                {
                  "author_key": [
                    "OL10026056A"
                  ],
                  "author_name": [
                    "Butcher MARTESHA"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2021,
                  "has_fulltext": false,
                  "key": "/works/OL36351249W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Lord of the Rings Film Facts : Everything for the Lord of the Rings Fans"
                },
                {
                  "author_key": [
                    "OL9829754A"
                  ],
                  "author_name": [
                    "Taylor MAELEE"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2021,
                  "has_fulltext": false,
                  "key": "/works/OL26009314W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Lord of the Rings Trivia : the Lord of the Rings Facts and Quizzes"
                },
                {
                  "author_key": [
                    "OL13524430A"
                  ],
                  "author_name": [
                    "BookCaps Study Guides Staff"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2012,
                  "has_fulltext": false,
                  "key": "/works/OL40094465W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Fellowship of the Ring Pt. 1"
                },
                {
                  "author_key": [
                    "OL9464244A",
                    "OL9464245A"
                  ],
                  "author_name": [
                    "Prima Temp Authors Staff",
                    "Prima Games Staff"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2004,
                  "has_fulltext": false,
                  "key": "/works/OL25353670W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Lord of the Rings"
                },
                {
                  "author_key": [
                    "OL3317161A"
                  ],
                  "author_name": [
                    "Betsy Gallup"
                  ],
                  "cover_edition_key": "OL9729713M",
                  "cover_i": 1972472,
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2006,
                  "has_fulltext": false,
                  "key": "/works/OL9262013W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Lord of the Rings"
                },
                {
                  "author_key": [
                    "OL2858510A"
                  ],
                  "author_name": [
                    "Elijah Wood"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2010,
                  "has_fulltext": false,
                  "key": "/works/OL33984094W",
                  "public_scan_b": false,
                  "title": "Lord of the Rings"
                },
                {
                  "author_key": [
                    "OL2821360A"
                  ],
                  "author_name": [
                    "Mark Cohen"
                  ],
                  "cover_i": 510582,
                  "ebook_access": "no_ebook",
                  "edition_count": 0,
                  "has_fulltext": false,
                  "key": "/works/OL8456213W",
                  "public_scan_b": false,
                  "subtitle": "The Fellowship of the Ring",
                  "title": "The Lord of the Rings"
                },
                {
                  "cover_i": 8456481,
                  "ebook_access": "no_ebook",
                  "edition_count": 0,
                  "has_fulltext": false,
                  "key": "/works/OL19342812W",
                  "public_scan_b": false,
                  "title": "The Lord of the Rings: The Fellowship of the Ring"
                },
                {
                  "author_key": [
                    "OL11117793A"
                  ],
                  "author_name": [
                    "Edwin Penfold"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2019,
                  "has_fulltext": false,
                  "key": "/works/OL30485058W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Lord of the Rings"
                },
                {
                  "author_key": [
                    "OL14256959A"
                  ],
                  "author_name": [
                    "George Duckett"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2016,
                  "has_fulltext": false,
                  "key": "/works/OL40339856W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Lord of the Rings"
                },
                {
                  "author_key": [
                    "OL10330532A"
                  ],
                  "author_name": [
                    "The Lord Of The Rings Publishing"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2021,
                  "has_fulltext": false,
                  "key": "/works/OL27658078W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Official the lôrd of the Rîngs 2022 Calendar"
                },
                {
                  "author_key": [
                    "OL26320A"
                  ],
                  "author_name": [
                    "J.R.R. Tolkien"
                  ],
                  "cover_edition_key": "OL47130517M",
                  "cover_i": 13523021,
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2002,
                  "has_fulltext": false,
                  "key": "/works/OL34779667W",
                  "public_scan_b": false,
                  "title": "The Lord of the Rings, Part 1"
                },
                {
                  "author_key": [
                    "OL26320A"
                  ],
                  "author_name": [
                    "J.R.R. Tolkien"
                  ],
                  "cover_edition_key": "OL33869743M",
                  "cover_i": 11983277,
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2002,
                  "has_fulltext": false,
                  "key": "/works/OL25291356W",
                  "public_scan_b": false,
                  "title": "The \" Lord of the Rings \" Jigsaw Book"
                },
                {
                  "author_key": [
                    "OL50039A"
                  ],
                  "author_name": [
                    "Laurence Gardner"
                  ],
                  "cover_edition_key": "OL8803116M",
                  "cover_i": 956526,
                  "ebook_access": "borrowable",
                  "edition_count": 7,
                  "first_publish_year": 2000,
                  "has_fulltext": true,
                  "ia": [
                    "unset0000unse_n1d6"
                  ],
                  "ia_collection_s": "inlibrary;internetarchivebooks;printdisabled;universityofarizona-ol",
                  "key": "/works/OL646331W",
                  "language": [
                    "eng"
                  ],
                  "lending_edition_s": "OL23015935M",
                  "lending_identifier_s": "unset0000unse_n1d6",
                  "public_scan_b": false,
                  "title": "Realm of the Ring Lords"
                },
                {
                  "author_key": [
                    "OL26320A"
                  ],
                  "author_name": [
                    "J.R.R. Tolkien"
                  ],
                  "cover_edition_key": "OL9429879M",
                  "cover_i": 149269,
                  "ebook_access": "no_ebook",
                  "edition_count": 3,
                  "first_publish_year": 1994,
                  "has_fulltext": false,
                  "key": "/works/OL27453W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Poems from The lord of the rings"
                },
                {
                  "author_key": [
                    "OL3028400A"
                  ],
                  "author_name": [
                    "Duncan Scott"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2014,
                  "has_fulltext": false,
                  "key": "/works/OL41480624W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Lord of the Rings Trilogy : the Language"
                },
                {
                  "author_key": [
                    "OL6916799A"
                  ],
                  "author_name": [
                    "Patrick Gardner"
                  ],
                  "cover_edition_key": "OL8821524M",
                  "cover_i": 4853661,
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2002,
                  "has_fulltext": false,
                  "key": "/works/OL14933438W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "The Lord of the Rings"
                },
                {
                  "author_key": [
                    "OL1399851A"
                  ],
                  "author_name": [
                    "Jude Fisher"
                  ],
                  "cover_edition_key": "OL9216186M",
                  "cover_i": 8830,
                  "ebook_access": "no_ebook",
                  "edition_count": 2,
                  "first_publish_year": 2001,
                  "has_fulltext": false,
                  "key": "/works/OL5753832W",
                  "public_scan_b": false,
                  "title": "The Fellowship of the Ring Visual Companion (The Lord of The Rings)"
                },
                {
                  "author_key": [
                    "OL13696562A",
                    "OL7958794A"
                  ],
                  "author_name": [
                    "J. R. R. Tolkien",
                    "Alan Lee"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 2,
                  "first_publish_year": 1992,
                  "has_fulltext": false,
                  "key": "/works/OL38128342W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Lord of the Rings"
                },
                {
                  "author_key": [
                    "OL2853379A"
                  ],
                  "author_name": [
                    "Cedco Publishing"
                  ],
                  "cover_edition_key": "OL8065474M",
                  "cover_i": 528849,
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2001,
                  "has_fulltext": false,
                  "key": "/works/OL8527313W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "The Fellowship of the Ring Journal (The Lord of the Rings)"
                },
                {
                  "author_key": [
                    "OL232748A"
                  ],
                  "author_name": [
                    "Henry Beard"
                  ],
                  "cover_edition_key": "OL24959695M",
                  "cover_i": 6943827,
                  "ebook_access": "printdisabled",
                  "edition_count": 2,
                  "first_publish_year": 1969,
                  "has_fulltext": true,
                  "ia": [
                    "bwb_S0-BEU-681",
                    "boredofringsparo00bear"
                  ],
                  "ia_collection_s": "cnusd-ol;internetarchivebooks;openlibrary-d-ol;printdisabled",
                  "key": "/works/OL16060879W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Bored of the rings"
                },
                {
                  "author_key": [
                    "OL3053048A"
                  ],
                  "author_name": [
                    "Rick Priestly"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2001,
                  "has_fulltext": false,
                  "key": "/works/OL31654551W",
                  "public_scan_b": false,
                  "title": "The Lord of the Rings"
                },
                {
                  "author_key": [
                    "OL26320A",
                    "OL2820148A",
                    "OL2786312A",
                    "OL2659480A",
                    "OL5011462A"
                  ],
                  "author_name": [
                    "J.R.R. Tolkien",
                    "Full Cast",
                    "Ian Holm",
                    "Michael Hordern",
                    "Robert Stephens"
                  ],
                  "cover_edition_key": "OL45357573M",
                  "cover_i": 13129075,
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2001,
                  "has_fulltext": false,
                  "key": "/works/OL33444980W",
                  "public_scan_b": false,
                  "title": "The Lord Of The Rings Part One"
                },
                {
                  "author_key": [
                    "OL3512059A"
                  ],
                  "author_name": [
                    "Suzette Bell"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2004,
                  "has_fulltext": false,
                  "key": "/works/OL9499103W",
                  "public_scan_b": false,
                  "title": "Lord of the Rings--War of the Ring - Expansion #1"
                },
                {
                  "author_key": [
                    "OL1401384A"
                  ],
                  "author_name": [
                    "Gary Russell"
                  ],
                  "cover_edition_key": "OL9216706M",
                  "cover_i": 9953,
                  "ebook_access": "no_ebook",
                  "edition_count": 2,
                  "first_publish_year": 2002,
                  "has_fulltext": false,
                  "key": "/works/OL5758759W",
                  "public_scan_b": false,
                  "title": "The Art of the \"Fellowship of the Ring\" (\"Lord of the Rings\")"
                },
                {
                  "cover_edition_key": "OL8065476M",
                  "cover_i": 528851,
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2001,
                  "has_fulltext": false,
                  "key": "/works/OL36522908W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Lord of the Rings Arwen Journal"
                },
                {
                  "author_key": [
                    "OL26320A"
                  ],
                  "author_name": [
                    "J.R.R. Tolkien"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 1930,
                  "has_fulltext": false,
                  "key": "/works/OL32236407W",
                  "language": [
                    "chi"
                  ],
                  "public_scan_b": false,
                  "title": "Zhi huan mo"
                },
                {
                  "author_key": [
                    "OL2834626A"
                  ],
                  "author_name": [
                    "Howard Shore"
                  ],
                  "cover_edition_key": "OL8005590M",
                  "cover_i": 1416148,
                  "ebook_access": "no_ebook",
                  "edition_count": 5,
                  "first_publish_year": 2004,
                  "has_fulltext": false,
                  "key": "/works/OL8488048W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Lord of the Rings Instrumental Solos"
                },
                {
                  "author_key": [
                    "OL3822898A"
                  ],
                  "author_name": [
                    "Carla Fritsch"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2004,
                  "has_fulltext": false,
                  "key": "/works/OL9838681W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Lord of the Rings"
                },
                {
                  "author_key": [
                    "OL3398638A"
                  ],
                  "author_name": [
                    "Lansdown"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 1999,
                  "has_fulltext": false,
                  "key": "/works/OL29335928W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Lords of the Ring"
                },
                {
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "has_fulltext": false,
                  "key": "/works/OL38061742W",
                  "public_scan_b": false,
                  "title": "Lord of the Rings"
                },
                {
                  "author_key": [
                    "OL12459051A"
                  ],
                  "author_name": [
                    "V. K. VIJAY"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2021,
                  "has_fulltext": false,
                  "key": "/works/OL36274175W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Lord of the Ring's"
                },
                {
                  "author_key": [
                    "OL10991076A"
                  ],
                  "author_name": [
                    "Nameless"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2013,
                  "has_fulltext": false,
                  "key": "/works/OL41780195W",
                  "language": [
                    "gre"
                  ],
                  "public_scan_b": false,
                  "title": "Lord of the Rings"
                },
                {
                  "author_key": [
                    "OL6595630A"
                  ],
                  "author_name": [
                    "jude Fisher"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "has_fulltext": false,
                  "key": "/works/OL13754671W",
                  "public_scan_b": false,
                  "title": "Lord of the rings"
                },
                {
                  "author_key": [
                    "OL6376891A"
                  ],
                  "author_name": [
                    "Bo Hansson"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "has_fulltext": false,
                  "key": "/works/OL13508175W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Lord of the rings"
                },
                {
                  "author_key": [
                    "OL2659937A"
                  ],
                  "author_name": [
                    "Various Artists"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2002,
                  "has_fulltext": false,
                  "key": "/works/OL10069759W",
                  "public_scan_b": false,
                  "title": "Lord of the Rings"
                },
                {
                  "author_key": [
                    "OL193277A"
                  ],
                  "author_name": [
                    "Peter Corris"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 1980,
                  "has_fulltext": false,
                  "key": "/works/OL1698390W",
                  "public_scan_b": false,
                  "title": "Lords of the ring"
                },
                {
                  "author_key": [
                    "OL597415A"
                  ],
                  "author_name": [
                    "William Wilson"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2014,
                  "has_fulltext": false,
                  "key": "/works/OL41346688W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Lord of the Rings Roleplay"
                },
                {
                  "author_key": [
                    "OL14413304A"
                  ],
                  "author_name": [
                    "Top 50 Facts Staff"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2014,
                  "has_fulltext": false,
                  "key": "/works/OL41421108W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Lord of the Rings"
                },
                {
                  "author_key": [
                    "OL9317449A"
                  ],
                  "author_name": [
                    "Rolf Witzsche"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2016,
                  "has_fulltext": false,
                  "key": "/works/OL41603490W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Lord of the Rings' Metaphors"
                },
                {
                  "author_key": [
                    "OL11361720A"
                  ],
                  "author_name": [
                    "Charles M Johnson"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2022,
                  "has_fulltext": false,
                  "key": "/works/OL34467294W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Lord of the Rings the Fellowship of the Ring Sheet Music Piano"
                },
                {
                  "author_key": [
                    "OL12520859A"
                  ],
                  "author_name": [
                    "J.R.R. Tolkein"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 1978,
                  "has_fulltext": false,
                  "key": "/works/OL34714467W",
                  "public_scan_b": false,
                  "title": "The Lord of the Rings"
                },
                {
                  "author_key": [
                    "OL738083A",
                    "OL801796A"
                  ],
                  "author_name": [
                    "Vyv Simson",
                    "Andrew Jennings"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 2,
                  "first_publish_year": 1992,
                  "has_fulltext": false,
                  "key": "/works/OL8270320W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "The lords of the rings"
                },
                {
                  "author_key": [
                    "OL14456887A",
                    "OL13696562A",
                    "OL14456888A"
                  ],
                  "author_name": [
                    "Editorial Editorial World",
                    "J. R. R. Tolkien",
                    "Robert Robert Thompson"
                  ],
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2015,
                  "has_fulltext": false,
                  "key": "/works/OL40334275W",
                  "language": [
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "Fellowship of the Ring"
                },
                {
                  "author_key": [
                    "OL1401384A"
                  ],
                  "author_name": [
                    "Gary Russell"
                  ],
                  "cover_edition_key": "OL9218391M",
                  "cover_i": 12822,
                  "ebook_access": "no_ebook",
                  "edition_count": 2,
                  "first_publish_year": 2004,
                  "has_fulltext": false,
                  "key": "/works/OL5758761W",
                  "public_scan_b": false,
                  "title": "The Art of the \"Lord of the Rings\" Trilogy (\"Lord of the Rings\")"
                },
                {
                  "author_key": [
                    "OL3052077A",
                    "OL3052066A"
                  ],
                  "author_name": [
                    "Alessio Cavatore",
                    "Rick Priestley"
                  ],
                  "cover_edition_key": "OL8920312M",
                  "cover_i": 6987479,
                  "ebook_access": "borrowable",
                  "edition_count": 1,
                  "first_publish_year": 2003,
                  "has_fulltext": true,
                  "ia": [
                    "lordofringstwoto00cava"
                  ],
                  "ia_collection_s": "inlibrary;internetarchivebooks;printdisabled",
                  "key": "/works/OL16287785W",
                  "lending_edition_s": "OL8920312M",
                  "lending_identifier_s": "lordofringstwoto00cava",
                  "public_scan_b": false,
                  "title": "The Lord of the Rings - The Two Towers"
                },
                {
                  "author_key": [
                    "OL2133665A"
                  ],
                  "author_name": [
                    "Peter Arnold"
                  ],
                  "cover_edition_key": "OL10918978M",
                  "cover_i": 2539329,
                  "ebook_access": "borrowable",
                  "edition_count": 1,
                  "first_publish_year": 1998,
                  "has_fulltext": true,
                  "ia": [
                    "lordsofringgreat0000arno"
                  ],
                  "ia_collection_s": "inlibrary;internetarchivebooks;printdisabled",
                  "key": "/works/OL7284693W",
                  "language": [
                    "eng"
                  ],
                  "lending_edition_s": "OL10918978M",
                  "lending_identifier_s": "lordsofringgreat0000arno",
                  "public_scan_b": false,
                  "title": "Lords of the Ring"
                },
                {
                  "author_key": [
                    "OL475982A"
                  ],
                  "author_name": [
                    "Brian Sibley"
                  ],
                  "cover_edition_key": "OL3700728M",
                  "cover_i": 393992,
                  "ebook_access": "no_ebook",
                  "edition_count": 2,
                  "first_publish_year": 2002,
                  "has_fulltext": false,
                  "key": "/works/OL3062780W",
                  "language": [
                    "dut",
                    "eng"
                  ],
                  "public_scan_b": false,
                  "title": "The Lord of the Rings"
                },
                {
                  "author_key": [
                    "OL26320A"
                  ],
                  "author_name": [
                    "J.R.R. Tolkien"
                  ],
                  "cover_edition_key": "OL39810596M",
                  "cover_i": 12928339,
                  "ebook_access": "borrowable",
                  "edition_count": 1,
                  "first_publish_year": 2002,
                  "has_fulltext": true,
                  "ia": [
                    "panjiuichewang0000tolk"
                  ],
                  "ia_collection_s": "inlibrary;internetarchivebooks;printdisabled",
                  "key": "/works/OL38058352W",
                  "language": [
                    "kor"
                  ],
                  "lending_edition_s": "OL39810596M",
                  "lending_identifier_s": "panjiuichewang0000tolk",
                  "public_scan_b": false,
                  "title": "반지의제왕 1"
                },
                {
                  "author_key": [
                    "OL26320A"
                  ],
                  "author_name": [
                    "J.R.R. Tolkien"
                  ],
                  "cover_edition_key": "OL43496350M",
                  "cover_i": 14569144,
                  "ebook_access": "no_ebook",
                  "edition_count": 1,
                  "first_publish_year": 2014,
                  "has_fulltext": false,
                  "key": "/works/OL31799539W",
                  "language": [
                    "heb"
                  ],
                  "public_scan_b": false,
                  "title": "Ḥavurat ha-ṭabaʻat"
                }
              ]
            }
            """;

        public static string EditionsTestResult = """
            {
              "links": {
                "self": "/works/OL27448W/editions.json",
                "work": "/works/OL27448W",
                "next": "/works/OL27448W/editions.json?offset=50"
              },
              "size": 251,
              "entries": [
                {
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "title": "O Senhor dos Anéis",
                  "publishers": [
                    "HarperCollins"
                  ],
                  "publish_date": "20 dezembro 2021",
                  "key": "/books/OL58959679M",
                  "type": {
                    "key": "/type/edition"
                  },
                  "identifiers": {},
                  "covers": [
                    15024346
                  ],
                  "edition_name": "Edição de Colecionador com Ilustrações de Alan Lee",
                  "contributors": [
                    {
                      "role": "Illustrator",
                      "name": "Alan Lee"
                    },
                    {
                      "role": "Translator",
                      "name": "Ronald Kyrmse"
                    }
                  ],
                  "languages": [
                    {
                      "key": "/languages/por"
                    }
                  ],
                  "translation_of": "The Lord of the Rings",
                  "translated_from": [
                    {
                      "key": "/languages/eng"
                    }
                  ],
                  "description": "Conheça a edição de O Senhor dos Anéis mais completa já produzida no Brasil! Aqui, temos a grande obra-prima de J.R.R. Tolkien como o mestre da fantasia sempre a imaginou: em um volume único. Ainda mais fantástica, esta edição de colecionador conta com luva de acetato transparente, o livro de Mazarbul e ilustrações coloridas de Alan Lee, ganhador do Oscar.\r\n\r\nApesar de ter sido publicado em três volumes – \"A Sociedade do Anel\", \"As Duas Torres\" e \"O Retorno do Rei\" – desde os anos 1950, o Senhor dos Anéis não é exatamente uma trilogia, mas um único grande romance que só pode ser compreendido em seu conjunto, segundo a concepção de seu autor, J.R.R. Tolkien. Em volume único, essa edição suntuosa da obra-prima de Tolkien, ilustrada em aquarela pelo aclamado e premiado artista Alan Lee e abrigada em uma caixa transparente, é uma das mais completas edições já publicadas.",
                  "physical_format": "Capa Dura",
                  "number_of_pages": 1376,
                  "isbn_13": [
                    "9786555112511"
                  ],
                  "latest_revision": 5,
                  "revision": 5,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2025-05-08T12:59:06.272580"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2025-05-08T13:10:24.378761"
                  }
                },
                {
                  "title": "Wladca Pierscieni [The Lord of The Rings - Three Volume Set in Polish]",
                  "type": {
                    "key": "/type/edition"
                  },
                  "isbn_10": [
                    "8373199772"
                  ],
                  "isbn_13": [
                    "9788373199774"
                  ],
                  "local_id": [
                    "urn:bwbsku:KQ-495-388"
                  ],
                  "source_records": [
                    "promise:bwb_daily_pallets_2022-03-17"
                  ],
                  "key": "/books/OL43140390M",
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "latest_revision": 3,
                  "revision": 3,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2022-12-07T13:46:37.792733"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T17:17:37.459017"
                  }
                },
                {
                  "publishers": [
                    "Fabbri"
                  ],
                  "subtitle": "II",
                  "source_records": [
                    "amazon:8845290050"
                  ],
                  "title": "Signore Degli Anelli",
                  "notes": {
                    "type": "/type/text",
                    "value": "Source title: Signore Degli Anelli: II (Italian Edition)"
                  },
                  "isbn_13": [
                    "9788845290053"
                  ],
                  "covers": [
                    10515650
                  ],
                  "physical_format": "paperback",
                  "full_title": "Signore Degli Anelli : II",
                  "isbn_10": [
                    "8845290050"
                  ],
                  "publish_date": "Nov 21, 2002",
                  "key": "/books/OL31403985M",
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "type": {
                    "key": "/type/edition"
                  },
                  "latest_revision": 3,
                  "revision": 3,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2020-11-21T15:37:20.577234"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T17:04:17.962024"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "title": "Pack Trilogía El Señor de los Anillos",
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "publish_date": "Aug 31, 2022",
                  "source_records": [
                    "amazon:844501384X"
                  ],
                  "number_of_pages": 1662,
                  "publishers": [
                    "Booket"
                  ],
                  "physical_format": "mass market paperback",
                  "full_title": "Pack Trilogía El Señor de los Anillos : Incluye La Comunidad del Anillo, Las Dos Torres, El Retorno del Rey",
                  "subtitle": "Incluye La Comunidad del Anillo, Las Dos Torres, El Retorno del Rey",
                  "notes": "Source title: Pack Trilogía El Señor de los Anillos: Incluye La Comunidad del Anillo, Las Dos Torres, El Retorno del Rey",
                  "covers": [
                    13601172
                  ],
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL47181069M",
                  "identifiers": {},
                  "isbn_10": [
                    "844501384X"
                  ],
                  "isbn_13": [
                    "9788445013847"
                  ],
                  "classifications": {},
                  "languages": [
                    {
                      "key": "/languages/spa"
                    }
                  ],
                  "translation_of": "Lord of the Rings Trilogy",
                  "latest_revision": 4,
                  "revision": 4,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2023-03-18T07:08:57.496054"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T17:00:04.922687"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "title": "Le Seigneur des Anneaux",
                  "source_records": [
                    "amazon:226611087X"
                  ],
                  "publishers": [
                    "France Loisirs"
                  ],
                  "isbn_10": [
                    "226611087X"
                  ],
                  "isbn_13": [
                    "9782266110877"
                  ],
                  "physical_format": "hardcover",
                  "full_title": "Le Seigneur des Anneaux La Communauté de l'Anneau - Les Deux Tours - Le Retour du roi - Appendices et indexes",
                  "subtitle": "La Communauté de l'Anneau - Les Deux Tours - Le Retour du roi - Appendices et indexes",
                  "notes": {
                    "type": "/type/text",
                    "value": "Source title: Le Seigneur des Anneaux (3 volumes) : La Communauté de l'Anneau - Les Deux Tours - Le Retour du roi - Appendices et indexes"
                  },
                  "covers": [
                    13217523
                  ],
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL46534010M",
                  "latest_revision": 2,
                  "revision": 2,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2023-02-02T18:16:34.383778"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T17:00:04.922687"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "languages": [
                    {
                      "key": "/languages/ger"
                    }
                  ],
                  "publish_date": "2003",
                  "publishers": [
                    "Klett-Cotta"
                  ],
                  "source_records": [
                    "bwb:9783608933536"
                  ],
                  "title": "Herr der Ringe",
                  "subtitle": "Die Wiederkehr des Konigs",
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL48608497M",
                  "identifiers": {},
                  "isbn_13": [
                    "9783608933536"
                  ],
                  "classifications": {},
                  "translation_of": "Return of the King",
                  "translated_from": [
                    {
                      "key": "/languages/eng"
                    }
                  ],
                  "latest_revision": 4,
                  "revision": 4,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2023-07-17T04:24:32.457990"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T16:47:26.235123"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "title": "Der Herr Der Ringe Box set",
                  "source_records": [
                    "amazon:3129080007"
                  ],
                  "number_of_pages": 1257,
                  "publishers": [
                    "Hobbit press Klett Cotta"
                  ],
                  "isbn_10": [
                    "3129080007"
                  ],
                  "isbn_13": [
                    "9783129080009"
                  ],
                  "physical_format": "perfect paperback",
                  "full_title": "Der Herr Der Ringe Box set : Die Gefahrten, Die zwei Turme, Die Ruckkhr des Konigs",
                  "subtitle": "Die Gefahrten, Die zwei Turme, Die Ruckkhr des Konigs",
                  "covers": [
                    13120659
                  ],
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL45050302M",
                  "latest_revision": 2,
                  "revision": 2,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2022-12-29T11:22:47.723668"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T16:47:26.235123"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "title": "HERR DER RINGE 3 - MP3 - AUDIO",
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "publish_date": "Sep 12, 2007",
                  "source_records": [
                    "amazon:3867170355"
                  ],
                  "publishers": [
                    "der Hörverlag"
                  ],
                  "physical_format": "mp3 cd",
                  "covers": [
                    11658206
                  ],
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL33006725M",
                  "identifiers": {},
                  "isbn_10": [
                    "3867170355"
                  ],
                  "isbn_13": [
                    "9783867170352"
                  ],
                  "classifications": {},
                  "languages": [
                    {
                      "key": "/languages/ger"
                    }
                  ],
                  "translation_of": "The Return of the King",
                  "latest_revision": 4,
                  "revision": 4,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2021-08-16T15:22:45.743485"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T16:47:26.235123"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "title": "The Lord of the Rings [BOX SET]",
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "publish_date": "Dec 04, 1999",
                  "source_records": [
                    "amazon:0261103938",
                    "bwb:9780261103931"
                  ],
                  "publishers": [
                    "Harper Collins"
                  ],
                  "physical_format": "hardcover",
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL42871495M",
                  "covers": [
                    14166496
                  ],
                  "identifiers": {},
                  "isbn_10": [
                    "0261103938"
                  ],
                  "isbn_13": [
                    "9780261103931"
                  ],
                  "classifications": {},
                  "latest_revision": 6,
                  "revision": 6,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2022-12-04T01:42:20.070259"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "title": "The Lord of the Rings",
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    },
                    {
                      "key": "/authors/OL10355883A"
                    }
                  ],
                  "publish_date": "May 14, 1992",
                  "source_records": [
                    "amazon:4566023540"
                  ],
                  "publishers": [
                    "Hyoronsha"
                  ],
                  "isbn_10": [
                    "4566023540"
                  ],
                  "isbn_13": [
                    "9784566023543"
                  ],
                  "physical_format": "tankobon hardcover",
                  "full_title": "The Lord of the Rings The Fellowship of the Ring  [Japanese Edition]",
                  "subtitle": "The Fellowship of the Ring  [Japanese Edition]",
                  "notes": {
                    "type": "/type/text",
                    "value": "Source title: The Lord of the Rings: The Fellowship of the Ring (Book One) [Japanese Edition] (The Fellowship of the Ring, Volume # 1)"
                  },
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL37871183M",
                  "latest_revision": 4,
                  "revision": 4,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2022-05-14T07:24:48.479681"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "isbn_13": [
                    "9780063274730"
                  ],
                  "languages": [
                    {
                      "key": "/languages/eng"
                    }
                  ],
                  "pagination": "1248",
                  "publish_date": "2022",
                  "publishers": [
                    "HarperCollins Publishers",
                    "William Morrow"
                  ],
                  "source_records": [
                    "bwb:9780063274730",
                    "amazon:0063274736"
                  ],
                  "title": "Lord of the Rings",
                  "weight": "0.455",
                  "subtitle": "Special Edition",
                  "full_title": "Lord of the Rings Special Edition",
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL38062258M",
                  "covers": [
                    13806118
                  ],
                  "number_of_pages": 1248,
                  "latest_revision": 4,
                  "revision": 4,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2022-05-26T10:11:00.086786"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "isbn_13": [
                    "9780008537753"
                  ],
                  "languages": [
                    {
                      "key": "/languages/eng"
                    }
                  ],
                  "publish_date": "2022",
                  "publishers": [
                    "HarperCollins Publishers Limited"
                  ],
                  "source_records": [
                    "bwb:9780008537753"
                  ],
                  "title": "Lord of the Rings Boxed Set",
                  "full_title": "Lord of the Rings Boxed Set",
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL37341977M",
                  "latest_revision": 3,
                  "revision": 3,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2022-02-28T11:01:39.958648"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "isbn_13": [
                    "9780008537760"
                  ],
                  "languages": [
                    {
                      "key": "/languages/eng"
                    }
                  ],
                  "publish_date": "2022",
                  "publishers": [
                    "HarperCollins Publishers Limited"
                  ],
                  "source_records": [
                    "bwb:9780008537760"
                  ],
                  "title": "Lord of the Rings",
                  "full_title": "Lord of the Rings",
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL37341949M",
                  "latest_revision": 3,
                  "revision": 3,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2022-02-28T11:01:28.260363"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "authors": [
                    {
                      "key": "/authors/OL10271841A"
                    },
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "isbn_13": [
                    "9780618433223"
                  ],
                  "languages": [
                    {
                      "key": "/languages/eng"
                    }
                  ],
                  "publish_date": "2003",
                  "publishers": [
                    "Houghton Mifflin Harcourt Publishing Company"
                  ],
                  "source_records": [
                    "bwb:9780618433223"
                  ],
                  "subjects": [
                    "Art appreciation"
                  ],
                  "title": "Lord of the Rings",
                  "weight": "1.320",
                  "full_title": "Lord of the Rings",
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL37347552M",
                  "latest_revision": 3,
                  "revision": 3,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2022-02-28T14:41:10.305204"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "isbn_13": [
                    "9780395082577"
                  ],
                  "languages": [
                    {
                      "key": "/languages/eng"
                    }
                  ],
                  "publish_date": "1976",
                  "publishers": [
                    "Houghton Mifflin Harcourt Publishing Company"
                  ],
                  "source_records": [
                    "bwb:9780395082577"
                  ],
                  "subjects": [
                    "Fiction, fantasy, epic",
                    "Middle earth (imaginary place), fiction",
                    "Baggins, frodo (fictitious character), fiction",
                    "Gandalf (fictitious character), fiction"
                  ],
                  "title": "Lord of the Rings",
                  "full_title": "Lord of the Rings",
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL37348044M",
                  "latest_revision": 3,
                  "revision": 3,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2022-02-28T15:08:48.519504"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    },
                    {
                      "key": "/authors/OL7958794A"
                    }
                  ],
                  "isbn_13": [
                    "9780395604236"
                  ],
                  "languages": [
                    {
                      "key": "/languages/eng"
                    }
                  ],
                  "pagination": "1200",
                  "publish_date": "1991",
                  "publishers": [
                    "Houghton Mifflin Harcourt Publishing Company"
                  ],
                  "source_records": [
                    "bwb:9780395604236"
                  ],
                  "subjects": [
                    "Fiction, fantasy, epic",
                    "Middle earth (imaginary place), fiction",
                    "Baggins, frodo (fictitious character), fiction",
                    "Gandalf (fictitious character), fiction"
                  ],
                  "title": "Lord of the Rings",
                  "full_title": "Lord of the Rings",
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL37349289M",
                  "latest_revision": 3,
                  "revision": 3,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2022-02-28T16:24:59.311174"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "isbn_13": [
                    "9780618345847"
                  ],
                  "languages": [
                    {
                      "key": "/languages/eng"
                    }
                  ],
                  "pagination": "1168",
                  "publish_date": "2003",
                  "publishers": [
                    "Houghton Mifflin Harcourt Publishing Company"
                  ],
                  "source_records": [
                    "bwb:9780618345847"
                  ],
                  "subjects": [
                    "Fiction, fantasy, epic",
                    "Middle earth (imaginary place), fiction",
                    "Baggins, frodo (fictitious character), fiction",
                    "Gandalf (fictitious character), fiction"
                  ],
                  "title": "Lord of the Rings",
                  "weight": "1.270",
                  "full_title": "Lord of the Rings",
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL37353387M",
                  "latest_revision": 3,
                  "revision": 3,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2022-02-28T20:42:27.172164"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    },
                    {
                      "key": "/authors/OL2623360A"
                    }
                  ],
                  "isbn_13": [
                    "9780061917844"
                  ],
                  "languages": [
                    {
                      "key": "/languages/eng"
                    }
                  ],
                  "publish_date": "2009",
                  "publishers": [
                    "HarperCollins Publishers"
                  ],
                  "source_records": [
                    "bwb:9780061917844"
                  ],
                  "subjects": [
                    "Fiction, fantasy, epic"
                  ],
                  "title": "Lord of the Rings",
                  "full_title": "Lord of the Rings",
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL37359690M",
                  "latest_revision": 4,
                  "revision": 4,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2022-02-28T22:32:22.170756"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    },
                    {
                      "key": "/authors/OL2623360A"
                    }
                  ],
                  "isbn_13": [
                    "9780061917820"
                  ],
                  "languages": [
                    {
                      "key": "/languages/eng"
                    }
                  ],
                  "publish_date": "2009",
                  "publishers": [
                    "HarperCollins Publishers"
                  ],
                  "source_records": [
                    "bwb:9780061917820"
                  ],
                  "subjects": [
                    "Fiction, fantasy, epic"
                  ],
                  "title": "Lord of the Rings",
                  "full_title": "Lord of the Rings",
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL37363400M",
                  "latest_revision": 4,
                  "revision": 4,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2022-02-28T23:28:26.813152"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    },
                    {
                      "key": "/authors/OL2623360A"
                    }
                  ],
                  "isbn_13": [
                    "9780061917851"
                  ],
                  "languages": [
                    {
                      "key": "/languages/eng"
                    }
                  ],
                  "publish_date": "2009",
                  "publishers": [
                    "HarperCollins Publishers"
                  ],
                  "source_records": [
                    "bwb:9780061917851"
                  ],
                  "subjects": [
                    "Fiction, fantasy, epic"
                  ],
                  "title": "Lord of the Rings",
                  "full_title": "Lord of the Rings",
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL37367325M",
                  "latest_revision": 4,
                  "revision": 4,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2022-03-01T00:30:08.733309"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    },
                    {
                      "key": "/authors/OL2623360A"
                    }
                  ],
                  "isbn_13": [
                    "9780061917837"
                  ],
                  "languages": [
                    {
                      "key": "/languages/eng"
                    }
                  ],
                  "publish_date": "2009",
                  "publishers": [
                    "HarperCollins Publishers"
                  ],
                  "source_records": [
                    "bwb:9780061917837"
                  ],
                  "subjects": [
                    "Fiction, fantasy, epic"
                  ],
                  "title": "Lord of the Rings",
                  "full_title": "Lord of the Rings",
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL37371066M",
                  "latest_revision": 4,
                  "revision": 4,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2022-03-01T01:25:35.200391"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "title": "The Lord of the Rings Boxed Set : Contains TVTie-In editions of",
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "publish_date": "Sep 13, 2022",
                  "source_records": [
                    "amazon:0063270927",
                    "bwb:9780063270923"
                  ],
                  "publishers": [
                    "William Morrow Paperbacks"
                  ],
                  "isbn_10": [
                    "0063270927"
                  ],
                  "isbn_13": [
                    "9780063270923"
                  ],
                  "physical_format": "paperback",
                  "full_title": "The Lord of the Rings Boxed Set : Contains TVTie-In editions of : Fellowship of the Ring, The Two Towers, and The Return of the King",
                  "subtitle": "Fellowship of the Ring, The Two Towers, and The Return of the King",
                  "notes": {
                    "type": "/type/text",
                    "value": "Source title: The Lord of the Rings Boxed Set: Contains TVTie-In editions of: Fellowship of the Ring, The Two Towers, and The Return of the King"
                  },
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL37068792M",
                  "covers": [
                    13287138
                  ],
                  "latest_revision": 5,
                  "revision": 5,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2022-02-19T07:00:37.577617"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "publish_date": "1991",
                  "copyright_date": "1966",
                  "publish_country": "enk",
                  "languages": [
                    {
                      "key": "/languages/eng"
                    }
                  ],
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "other_titles": [
                    "Fellowship of the ring.",
                    "Two towers.",
                    "Return of the king."
                  ],
                  "notes": "Originally published: London, Allen & Unwin, 1954. Based on the reset edition originally published 2002.\r\n\r\nMaps on endpapers.\r\n\r\nIncludes index.",
                  "subjects": [
                    "Fantasy fiction"
                  ],
                  "title": "The Lord of the Rings",
                  "by_statement": "by J.R.R. Tolkien",
                  "publishers": [
                    "HarperCollins"
                  ],
                  "publish_places": [
                    "London"
                  ],
                  "pagination": "3 volumes",
                  "source_records": [
                    "ia:lordofrings0000tolk_j2h8",
                    "promise:bwb_daily_pallets_2021-07-13",
                    "bwb:9780007887682",
                    "bwb:9780007887668",
                    "amazon:0007887671"
                  ],
                  "full_title": "The lord of the rings",
                  "covers": [
                    13201380
                  ],
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL36643488M",
                  "identifiers": {},
                  "classifications": {},
                  "local_id": [
                    "urn:bwbsku:O7-CHY-507"
                  ],
                  "isbn_10": [
                    "0007887663",
                    "0007887671",
                    "000788768X"
                  ],
                  "isbn_13": [
                    "9780007887668",
                    "9780007887675",
                    "9780007887682"
                  ],
                  "oclc_numbers": [
                    "1067124928"
                  ],
                  "lc_classifications": [
                    "PR6039.O32 L6 2010"
                  ],
                  "latest_revision": 11,
                  "revision": 11,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2022-01-08T05:03:37.275963"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-23T17:43:25.993946"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "title": "Der Herr der Ringe",
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "publish_date": "Oct 20, 2021",
                  "source_records": [
                    "amazon:3608980806"
                  ],
                  "publishers": [
                    "Klett-Cotta Verlag"
                  ],
                  "physical_format": "hardcover",
                  "full_title": "Der Herr der Ringe mit Illustrationen des Autors",
                  "subtitle": "mit Illustrationen des Autors",
                  "notes": "Source title: Der Herr der Ringe: mit Illustrationen des Autors",
                  "covers": [
                    12506175
                  ],
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL36315201M",
                  "identifiers": {},
                  "isbn_10": [
                    "3608980806"
                  ],
                  "isbn_13": [
                    "9783608980806"
                  ],
                  "classifications": {},
                  "languages": [
                    {
                      "key": "/languages/ger"
                    }
                  ],
                  "translation_of": "The Lord of the Rings",
                  "latest_revision": 4,
                  "revision": 4,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2021-12-30T09:10:35.081123"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "isbn_13": [
                    "9780358623403"
                  ],
                  "languages": [
                    {
                      "key": "/languages/eng"
                    }
                  ],
                  "pagination": "1248",
                  "publish_date": "2021",
                  "publishers": [
                    "Houghton Mifflin Harcourt Publishing Company"
                  ],
                  "source_records": [
                    "bwb:9780358623403"
                  ],
                  "title": "Lord of the Rings Illustrated Edition",
                  "weight": "0.455",
                  "full_title": "Lord of the Rings Illustrated Edition",
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL36097202M",
                  "latest_revision": 3,
                  "revision": 3,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2021-12-28T09:01:19.775824"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "title": "The Lord of The Rings",
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "publish_date": "Dec 07, 2001",
                  "source_records": [
                    "amazon:0261103687",
                    "bwb:9780261103689"
                  ],
                  "number_of_pages": 1152,
                  "publishers": [
                    "Houghton Mifflin"
                  ],
                  "isbn_10": [
                    "0261103687"
                  ],
                  "isbn_13": [
                    "9780261103689"
                  ],
                  "physical_format": "hardcover",
                  "full_title": "The Lord of The Rings",
                  "covers": [
                    12393153
                  ],
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL35698544M",
                  "latest_revision": 4,
                  "revision": 4,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2021-12-07T10:02:09.053824"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "title": "The Lord of the Rings",
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "publish_date": "Sep 30, 2002",
                  "source_records": [
                    "amazon:0618260293"
                  ],
                  "number_of_pages": 1124,
                  "publishers": [
                    "Houghton Mifflin",
                    "Brand: Mariner Books"
                  ],
                  "isbn_10": [
                    "0618260293"
                  ],
                  "isbn_13": [
                    "9780618260294"
                  ],
                  "physical_format": "paperback",
                  "full_title": "The Lord of the Rings",
                  "covers": [
                    12388843
                  ],
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL35688477M",
                  "latest_revision": 3,
                  "revision": 3,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2021-11-30T04:30:27.761113"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "isbn_13": [
                    "9780008501310"
                  ],
                  "languages": [
                    {
                      "key": "/languages/eng"
                    }
                  ],
                  "publish_date": "2021",
                  "publishers": [
                    "HarperCollins Publishers Limited"
                  ],
                  "source_records": [
                    "bwb:9780008501310"
                  ],
                  "title": "Lord of the Rings",
                  "full_title": "Lord of the Rings",
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL35869097M",
                  "latest_revision": 3,
                  "revision": 3,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2021-12-26T09:07:32.650983"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "isbn_13": [
                    "9781299884953"
                  ],
                  "languages": [
                    {
                      "key": "/languages/eng"
                    }
                  ],
                  "publish_date": "2013",
                  "publishers": [
                    "Houghton Mifflin Harcourt Trade & Reference Publishers"
                  ],
                  "source_records": [
                    "bwb:9781299884953"
                  ],
                  "title": "Lord of the Rings",
                  "subtitle": "One Volume",
                  "full_title": "Lord of the Rings One Volume",
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL37175817M",
                  "latest_revision": 3,
                  "revision": 3,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2022-02-26T19:18:16.173858"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "title": "Der Herr der Ringe",
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "publish_date": "Oct 14, 2015",
                  "source_records": [
                    "amazon:3608960899"
                  ],
                  "publishers": [
                    "Klett-Cotta Verlag"
                  ],
                  "physical_format": "Paperback",
                  "full_title": "Der Herr der Ringe Sonderausgabe",
                  "subtitle": "Sonderausgabe",
                  "notes": "Source title: Der Herr der Ringe: Sonderausgabe",
                  "covers": [
                    11401675
                  ],
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL32771847M",
                  "identifiers": {},
                  "classifications": {},
                  "physical_dimensions": "22 x 14 x 7 centimeters",
                  "weight": "2 kilos",
                  "edition_name": "Hobbit Presse Paperback",
                  "translation_of": "The Lord of the Rings Trilogy",
                  "number_of_pages": 1543,
                  "isbn_10": [
                    "3608960899"
                  ],
                  "isbn_13": [
                    "9783608960891"
                  ],
                  "languages": [
                    {
                      "key": "/languages/ger"
                    }
                  ],
                  "latest_revision": 5,
                  "revision": 5,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2021-07-09T19:51:53.753494"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "publishers": [
                    "Warszawskie Wydawnictwo Literackie Muza"
                  ],
                  "physical_format": "Hardcover",
                  "title": "Władca Pierścieni",
                  "identifiers": {
                    "goodreads": [
                      "6657492"
                    ],
                    "librarything": [
                      "3203347"
                    ]
                  },
                  "languages": [
                    {
                      "key": "/languages/pol"
                    }
                  ],
                  "publish_date": "2002",
                  "key": "/books/OL13184349M",
                  "type": {
                    "key": "/type/edition"
                  },
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "isbn_10": [
                    "8373191720"
                  ],
                  "isbn_13": [
                    "9788373191723"
                  ],
                  "classifications": {},
                  "latest_revision": 12,
                  "revision": 12,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2008-04-30T20:50:18.033121"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "title": "Der Herr der Ringe - Neuausgabe 2012",
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "publish_date": "Sep 01, 2012",
                  "source_records": [
                    "amazon:3608939849"
                  ],
                  "publishers": [
                    "Klett-Cotta Verlag"
                  ],
                  "physical_format": "paperback",
                  "full_title": "Der Herr der Ringe - Neuausgabe 2012 : Neuüberarbeitung der Übersetzung von Wolfgang Krege, überarbeitet und aktualisiert",
                  "subtitle": "Neuüberarbeitung der Übersetzung von Wolfgang Krege, überarbeitet und aktualisiert",
                  "notes": "Source title: Der Herr der Ringe - Neuausgabe 2012: Neuüberarbeitung der Übersetzung von Wolfgang Krege, überarbeitet und aktualisiert",
                  "covers": [
                    11183830
                  ],
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL32534425M",
                  "identifiers": {},
                  "isbn_10": [
                    "3608939849"
                  ],
                  "isbn_13": [
                    "9783608939842"
                  ],
                  "classifications": {},
                  "contributors": [
                    {
                      "role": "Translator",
                      "name": "Wolfgang Krege"
                    }
                  ],
                  "languages": [
                    {
                      "key": "/languages/ger"
                    }
                  ],
                  "translation_of": "Lord of the Rings Trilogy",
                  "latest_revision": 4,
                  "revision": 4,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2021-05-29T14:08:55.638514"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "title": "Le Seigneur des Anneaux, Intégrale",
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "publish_date": "Feb 15, 2018",
                  "source_records": [
                    "amazon:2266286269"
                  ],
                  "publishers": [
                    "Pocket",
                    "POCKET"
                  ],
                  "physical_format": "mass market paperback",
                  "notes": "Source title: Le Seigneur des Anneaux, Intégrale :",
                  "covers": [
                    10641294
                  ],
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL31962202M",
                  "number_of_pages": 1600,
                  "identifiers": {},
                  "isbn_10": [
                    "2266286269"
                  ],
                  "isbn_13": [
                    "9782266286268"
                  ],
                  "classifications": {},
                  "languages": [
                    {
                      "key": "/languages/fre"
                    }
                  ],
                  "translation_of": "Lord of the Rings Trilogy",
                  "latest_revision": 5,
                  "revision": 5,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2021-02-15T13:20:31.568034"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "publishers": [
                    "Minotauro Ediciones Avd"
                  ],
                  "source_records": [
                    "amazon:8445071785"
                  ],
                  "title": "El Señor De Los Anillos",
                  "notes": "Source title: El Señor De Los Anillos (3 Volumes) (Spanish Edition)",
                  "covers": [
                    -1
                  ],
                  "physical_format": "paperback",
                  "full_title": "El Señor De Los Anillos",
                  "publish_date": "Sep 21, 2002",
                  "key": "/books/OL30405705M",
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "type": {
                    "key": "/type/edition"
                  },
                  "identifiers": {},
                  "isbn_10": [
                    "8445071785"
                  ],
                  "isbn_13": [
                    "9788445071786"
                  ],
                  "classifications": {},
                  "languages": [
                    {
                      "key": "/languages/spa"
                    }
                  ],
                  "translation_of": "Lord of the Rings",
                  "latest_revision": 5,
                  "revision": 5,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2020-09-21T16:00:24.754424"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "title": "Yüzüklerin Efendisi",
                  "subtitle": "Yüzük Kardeşliği - İki Kule - Kralın Dönüşü",
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "publish_date": "2007",
                  "publishers": [
                    "Metis Yayıncılık"
                  ],
                  "covers": [
                    14627503
                  ],
                  "physical_format": "paperback",
                  "full_title": "Yüzüklerin Efendisi : Yüzük Kardeşliği - İki Kule - Kralın Dönüşü",
                  "source_records": [
                    "amazon:9753423470",
                    "promise:bwb_daily_pallets_2023-06-28:O9-APL-680"
                  ],
                  "type": {
                    "key": "/type/edition"
                  },
                  "local_id": [
                    "urn:bwbsku:O9-APL-680"
                  ],
                  "languages": [
                    {
                      "key": "/languages/tur"
                    }
                  ],
                  "translation_of": "Lord of the Rings",
                  "translated_from": [
                    {
                      "key": "/languages/eng"
                    }
                  ],
                  "key": "/books/OL30095043M",
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "identifiers": {},
                  "ocaid": "yzklerinefendisi0000jrrt",
                  "isbn_10": [
                    "9753423470"
                  ],
                  "isbn_13": [
                    "9789753423472"
                  ],
                  "classifications": {},
                  "publish_places": [
                    "Istanbul"
                  ],
                  "copyright_date": "2001",
                  "edition_name": "Uçüncü Basim: Ekim 2007",
                  "pagination": "1015 pages",
                  "latest_revision": 11,
                  "revision": 11,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2020-09-05T21:43:32.096400"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "publishers": [
                    "Klett-Cotta"
                  ],
                  "languages": [
                    {
                      "key": "/languages/ger"
                    }
                  ],
                  "weight": "4.6 pounds",
                  "title": "Der Herr der Ringe 1-3. Die Gefährten / Die zwei Türme / Die Rückkehr des Königs.",
                  "identifiers": {
                    "goodreads": [
                      "136777"
                    ],
                    "librarything": [
                      "1386651"
                    ]
                  },
                  "isbn_13": [
                    "9783608936667"
                  ],
                  "physical_format": "Hardcover",
                  "isbn_10": [
                    "3608936661"
                  ],
                  "publish_date": "June 1, 2002",
                  "key": "/books/OL9076618M",
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    },
                    {
                      "key": "/authors/OL3187759A"
                    }
                  ],
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "type": {
                    "key": "/type/edition"
                  },
                  "physical_dimensions": "8.8 x 5.8 x 4.2 inches",
                  "latest_revision": 7,
                  "revision": 7,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2008-04-30T09:38:13.731961"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "title": "Der Herr der Ringe : Erster Teil : Die Gefährten. Zweiter Teil : Die zwei Türme. Dritter Teil",
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "publish_date": "Aug 01, 2009",
                  "source_records": [
                    "amazon:3608938281"
                  ],
                  "publishers": [
                    "Klett-Cotta Verlag"
                  ],
                  "physical_format": "hardcover",
                  "full_title": "Der Herr der Ringe : Erster Teil : Die Gefährten. Zweiter Teil : Die zwei Türme. Dritter Teil : Die Rückkehr des Königs",
                  "subtitle": "Die Rückkehr des Königs",
                  "notes": "Source title: Der Herr der Ringe: Erster Teil: Die Gefährten. Zweiter Teil: Die zwei Türme. Dritter Teil: Die Rückkehr des Königs",
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL37766386M",
                  "covers": [
                    13147175
                  ],
                  "identifiers": {
                    "goodreads": [
                      "6536598"
                    ],
                    "librarything": [
                      "1386651"
                    ],
                    "dnb": [
                      "99386712X"
                    ]
                  },
                  "classifications": {},
                  "number_of_pages": 1295,
                  "isbn_10": [
                    "3608938281"
                  ],
                  "isbn_13": [
                    "9783608938289"
                  ],
                  "oclc_numbers": [
                    "1289624788"
                  ],
                  "languages": [
                    {
                      "key": "/languages/ger"
                    }
                  ],
                  "translation_of": "Lord of the Rings Trilogy",
                  "latest_revision": 7,
                  "revision": 7,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2022-03-18T18:25:58.418030"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "publishers": [
                    "Hör Verlag, München"
                  ],
                  "physical_format": "Audio CD",
                  "title": "Der Herr der Ringe, limitierte Amazon.de Sammleredition (11 CD's, Spielzeit 756 Minuten)",
                  "identifiers": {
                    "goodreads": [
                      "111936"
                    ],
                    "librarything": [
                      "8559359"
                    ]
                  },
                  "covers": [
                    3281185
                  ],
                  "languages": [
                    {
                      "key": "/languages/ger"
                    }
                  ],
                  "publish_date": "December 14, 2001",
                  "key": "/books/OL12985145M",
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "type": {
                    "key": "/type/edition"
                  },
                  "isbn_10": [
                    "3895847925"
                  ],
                  "isbn_13": [
                    "9783895847929"
                  ],
                  "classifications": {},
                  "translation_of": "The Lord of the Rings Trilogy",
                  "latest_revision": 9,
                  "revision": 9,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2008-04-30T20:50:18.033121"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "edition_name": "2nd ed.",
                  "source_records": [
                    "marc:talis_openlibrary_contribution/talis-openlibrary-contribution.mrc:938900878:687"
                  ],
                  "title": "The Lord of the Rings.",
                  "languages": [
                    {
                      "key": "/languages/eng"
                    }
                  ],
                  "publish_country": "enk",
                  "type": {
                    "key": "/type/edition"
                  },
                  "publishers": [
                    "HarperCollins"
                  ],
                  "key": "/books/OL22814360M",
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "publish_places": [
                    "London"
                  ],
                  "pagination": "529p.,(5)p. of plates :",
                  "dewey_decimal_class": [
                    "823.912"
                  ],
                  "notes": {
                    "type": "/type/text",
                    "value": "Originally published: London : Allen & Unwin, 1954."
                  },
                  "number_of_pages": 529,
                  "isbn_10": [
                    "0261102354"
                  ],
                  "publish_date": "1993",
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "latest_revision": 22,
                  "revision": 22,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2009-01-03T08:13:34.202412"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "table_of_contents": [
                    {
                      "level": 0,
                      "title": "pt. 1. The fellowship of the ring",
                      "type": {
                        "key": "/type/toc_item"
                      }
                    },
                    {
                      "level": 0,
                      "title": "pt. 2. The two towers",
                      "type": {
                        "key": "/type/toc_item"
                      }
                    },
                    {
                      "level": 0,
                      "title": "pt. 3. The return of the king.",
                      "type": {
                        "key": "/type/toc_item"
                      }
                    }
                  ],
                  "lc_classifications": [
                    "PR6039.O32 L6 2002b",
                    "PR6039.O32 L6 2002b"
                  ],
                  "url": [
                    "http://www.loc.gov/catdir/description/hm031/2002726623.html",
                    "http://www.houghtonmifflinbooks.com/readers%5Fguides/lotr/lotr%5Frg.shtml"
                  ],
                  "contributions": [
                    "Lee, Alan."
                  ],
                  "genres": [
                    "Fiction"
                  ],
                  "source_records": [
                    "marc:CollingswoodLibraryMarcDump10-27-2008/Collingswood.out:67205675:1987"
                  ],
                  "title": "The lord of the rings",
                  "work_titles": [
                    "Lord of the rings (2002)"
                  ],
                  "languages": [
                    {
                      "key": "/languages/eng"
                    }
                  ],
                  "subjects": [
                    "Baggins, Frodo (Fictitious character) -- Fiction",
                    "Middle Earth (Imaginary place) -- Fiction",
                    "Fantasy fiction, English"
                  ],
                  "publish_country": "mau",
                  "by_statement": "J.R.R. Tolkien ; illustrated by Alan Lee.",
                  "type": {
                    "key": "/type/edition"
                  },
                  "other_titles": [
                    "Fellowship of the ring.",
                    "Two towers.",
                    "Return of the king."
                  ],
                  "publishers": [
                    "Houghton Mifflin"
                  ],
                  "key": "/books/OL23274300M",
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "publish_places": [
                    "Boston"
                  ],
                  "pagination": "3 v. (xx, 1170 p.) :",
                  "dewey_decimal_class": [
                    "823/.912"
                  ],
                  "notes": {
                    "type": "/type/text",
                    "value": "Maps on lining pages.\n\nPart 3 includes index."
                  },
                  "number_of_pages": 1170,
                  "lccn": [
                    "2002726623"
                  ],
                  "isbn_10": [
                    "0618260587",
                    "061826051X",
                    "0618260595",
                    "0618260552",
                    "0739409557"
                  ],
                  "publish_date": "2002",
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "latest_revision": 24,
                  "revision": 24,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2009-05-29T21:11:57.970163"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-20T15:22:56.910944"
                  }
                },
                {
                  "publishers": [
                    "Christian Bourgois"
                  ],
                  "identifiers": {
                    "goodreads": [
                      "877746"
                    ],
                    "librarything": [
                      "3203350"
                    ],
                    "doi": [
                      "10.1604/9782266127929"
                    ]
                  },
                  "series": [
                    "Pocket -- 2658"
                  ],
                  "key": "/books/OL22050937M",
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "pagination": "569p.",
                  "source_records": [
                    "marc:talis_openlibrary_contribution/talis-openlibrary-contribution.mrc:998269011:574",
                    "bwb:9782266127929"
                  ],
                  "title": "Le seigneur des anneaux.",
                  "notes": {
                    "type": "/type/text",
                    "value": "Titre original: The lord of the rings. Vol.2: The two towers."
                  },
                  "number_of_pages": 569,
                  "languages": [
                    {
                      "key": "/languages/fre"
                    }
                  ],
                  "isbn_10": [
                    "2266127926"
                  ],
                  "publish_date": "1972",
                  "publish_country": "fr ",
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "type": {
                    "key": "/type/edition"
                  },
                  "latest_revision": 15,
                  "revision": 15,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2008-11-06T09:11:41.322020"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-08-17T03:37:51.666083"
                  }
                },
                {
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "title": "The Lord of the Rings",
                  "publishers": [
                    "Houghton Mifflin Company"
                  ],
                  "publish_date": "2003",
                  "key": "/books/OL51711484M",
                  "type": {
                    "key": "/type/edition"
                  },
                  "identifiers": {},
                  "isbn_10": [
                    "0618343997"
                  ],
                  "ocaid": "lordofrings00tolk_5",
                  "classifications": {},
                  "publish_places": [
                    "Boston"
                  ],
                  "copyright_date": "2003",
                  "edition_name": "Movie tie-in edition (1)",
                  "languages": [
                    {
                      "key": "/languages/eng"
                    }
                  ],
                  "physical_format": "hardcover",
                  "pagination": "1137p.",
                  "covers": [
                    14627570
                  ],
                  "latest_revision": 3,
                  "revision": 3,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2024-05-17T13:51:26.585267"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-17T13:53:37.764224"
                  }
                },
                {
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "title": "The Lord of the Rings",
                  "publishers": [
                    "Guild Publishing"
                  ],
                  "publish_date": "1990",
                  "key": "/books/OL51711071M",
                  "type": {
                    "key": "/type/edition"
                  },
                  "identifiers": {},
                  "covers": [
                    14627456
                  ],
                  "ocaid": "hobbitguildpubli0000jrrt",
                  "classifications": {},
                  "publish_places": [
                    "London"
                  ],
                  "copyright_date": "1966",
                  "languages": [
                    {
                      "key": "/languages/eng"
                    }
                  ],
                  "physical_format": "hardcover",
                  "number_of_pages": 1244,
                  "pagination": "1244p.",
                  "source_records": [
                    "ia:hobbitguildpubli0000jrrt"
                  ],
                  "latest_revision": 4,
                  "revision": 4,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2024-05-17T09:25:40.022225"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2025-05-03T15:55:14.740971"
                  }
                },
                {
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "title": "The Lord of the Rings",
                  "publishers": [
                    "Houghton Mifflin Company"
                  ],
                  "publish_date": "1987",
                  "key": "/books/OL51695300M",
                  "type": {
                    "key": "/type/edition"
                  },
                  "identifiers": {},
                  "isbn_10": [
                    "0395193958"
                  ],
                  "ocaid": "lordofrings0000tolk_k7n1",
                  "classifications": {},
                  "publish_places": [
                    "Boston"
                  ],
                  "copyright_date": "1987",
                  "edition_name": "Collector's Edition",
                  "languages": [
                    {
                      "key": "/languages/eng"
                    }
                  ],
                  "physical_format": "hardcover",
                  "pagination": "423, 352, 440 pages, 1 unnumbered folded leaf of plates",
                  "covers": [
                    14626129
                  ],
                  "latest_revision": 3,
                  "revision": 3,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2024-05-14T14:31:52.609110"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-14T14:32:51.272686"
                  }
                },
                {
                  "publishers": [
                    "Houghton Mifflin"
                  ],
                  "number_of_pages": 440,
                  "covers": [
                    -1
                  ],
                  "local_id": [
                    "urn:cst:10017043606"
                  ],
                  "lc_classifications": [
                    "PZ3.T576 Lo10",
                    "PR6039.O32 Lo10",
                    "PZ3.T576Lo10"
                  ],
                  "url": [
                    "http://www.loc.gov/catdir/samples/hm051/75308399.html",
                    "http://www.houghtonmifflinbooks.com/readers_guides/lotr/lotr_rg.shtml",
                    "http://www.loc.gov/catdir/description/hm021/75308399.html"
                  ],
                  "key": "/books/OL5237526M",
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "publish_places": [
                    "Boston"
                  ],
                  "subjects": [
                    "Baggins, Frodo (Fictitious character) -- Fiction",
                    "Middle Earth (Imaginary place) -- Fiction",
                    "Fantasy fiction, English"
                  ],
                  "uri_descriptions": [
                    "Sample text",
                    "Reading group guide",
                    "Publisher description"
                  ],
                  "edition_name": "[2d ed.] Collector's ed.",
                  "pagination": "423, 352, 440 p., [1] fold. leaf of plates :",
                  "source_records": [
                    "marc:marc_records_scriblio_net/part08.dat:162926093:1118",
                    "amazon:B00M0NFYTC",
                    "amazon:0395193958",
                    "marc:marc_claremont_school_theology/CSTMARC1_barcode.mrc:59196833:2516",
                    "marc:marc_loc_2016/BooksAll.2016.part09.utf8:61790681:1211",
                    "marc:marc_claremont_school_theology/CSTMARC1_multibarcode.mrc:59258377:2516",
                    "bwb:9780395193952"
                  ],
                  "title": "The lord of the rings",
                  "dewey_decimal_class": [
                    "823/.9/12"
                  ],
                  "notes": {
                    "type": "/type/text",
                    "value": "Includes indexes."
                  },
                  "identifiers": {
                    "goodreads": [
                      "569465"
                    ],
                    "librarything": [
                      "1386651"
                    ]
                  },
                  "languages": [
                    {
                      "key": "/languages/eng"
                    }
                  ],
                  "lccn": [
                    "75308399"
                  ],
                  "isbn_10": [
                    "0395193958"
                  ],
                  "publish_date": "1974",
                  "publish_country": "mau",
                  "by_statement": "J. R. R. Tolkien.",
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "type": {
                    "key": "/type/edition"
                  },
                  "uris": [
                    "http://www.loc.gov/catdir/samples/hm051/75308399.html",
                    "http://www.houghtonmifflinbooks.com/readers_guides/lotr/lotr_rg.shtml",
                    "http://www.loc.gov/catdir/description/hm021/75308399.html"
                  ],
                  "latest_revision": 23,
                  "revision": 23,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2008-04-01T03:28:50.625462"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-14T14:29:37.475975"
                  }
                },
                {
                  "publishers": [
                    "Allen & Unwin"
                  ],
                  "identifiers": {
                    "goodreads": [
                      "499550"
                    ],
                    "librarything": [
                      "3203350"
                    ]
                  },
                  "subtitle": "being the second part of The Lord of the rings.",
                  "key": "/books/OL20175829M",
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "publish_places": [
                    "London"
                  ],
                  "pagination": "352p. ;",
                  "source_records": [
                    "marc:talis_openlibrary_contribution/talis-openlibrary-contribution.mrc:2443883990:562"
                  ],
                  "title": "The Lord of the Rings.",
                  "number_of_pages": 352,
                  "languages": [
                    {
                      "key": "/languages/eng"
                    }
                  ],
                  "isbn_10": [
                    "0048230464"
                  ],
                  "publish_date": "1966",
                  "publish_country": "xxk",
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "type": {
                    "key": "/type/edition"
                  },
                  "latest_revision": 15,
                  "revision": 15,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2008-10-26T05:31:18.454734"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-14T10:34:17.238877"
                  }
                },
                {
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "title": "The Lord of the Rings",
                  "publishers": [
                    "Guild Publishing"
                  ],
                  "publish_date": "1981",
                  "key": "/books/OL51694024M",
                  "type": {
                    "key": "/type/edition"
                  },
                  "identifiers": {},
                  "covers": [
                    14828778,
                    14625765
                  ],
                  "ocaid": "lordofrings0000jrrt",
                  "classifications": {},
                  "publish_places": [
                    "London"
                  ],
                  "copyright_date": "1966",
                  "languages": [
                    {
                      "key": "/languages/eng"
                    }
                  ],
                  "physical_format": "hardcover",
                  "number_of_pages": 1077,
                  "pagination": "1077p.",
                  "source_records": [
                    "ia:lordofrings0000jrrt"
                  ],
                  "latest_revision": 6,
                  "revision": 6,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2024-05-13T17:58:18.944933"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2025-05-07T03:29:17.635611"
                  }
                },
                {
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "title": "The Lord of the Rings",
                  "publishers": [
                    "HarperCollins Publishers"
                  ],
                  "publish_date": "1993",
                  "key": "/books/OL51693405M",
                  "type": {
                    "key": "/type/edition"
                  },
                  "identifiers": {},
                  "isbn_10": [
                    "0261102435"
                  ],
                  "ocaid": "lordofrings0000tolk_o3c6",
                  "classifications": {},
                  "publish_places": [
                    "London"
                  ],
                  "copyright_date": "1966",
                  "edition_name": "paperback edition (2)",
                  "languages": [
                    {
                      "key": "/languages/eng"
                    }
                  ],
                  "physical_format": "paperback",
                  "pagination": "1193p.",
                  "covers": [
                    14625541
                  ],
                  "latest_revision": 3,
                  "revision": 3,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2024-05-13T10:21:04.873809"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-13T10:22:40.945285"
                  }
                },
                {
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "title": "Der Herr der Ringe",
                  "publishers": [
                    "Klett-Cotta"
                  ],
                  "publish_date": "2019",
                  "key": "/books/OL49215435M",
                  "type": {
                    "key": "/type/edition"
                  },
                  "covers": [
                    14393816
                  ],
                  "identifiers": {},
                  "isbn_13": [
                    "9783608964288"
                  ],
                  "classifications": {},
                  "languages": [
                    {
                      "key": "/languages/ger"
                    }
                  ],
                  "number_of_pages": 1293,
                  "translation_of": "The Lord of the Rings",
                  "physical_format": "gebundene Ausgabe",
                  "contributors": [
                    {
                      "name": "Margaret Carroux",
                      "role": "Translator"
                    }
                  ],
                  "publish_places": [
                    "Stuttgart, Germany"
                  ],
                  "translated_from": [
                    {
                      "key": "/languages/eng"
                    }
                  ],
                  "latest_revision": 3,
                  "revision": 3,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2023-07-28T10:19:53.696019"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2023-07-28T10:28:22.023226"
                  }
                },
                {
                  "type": {
                    "key": "/type/edition"
                  },
                  "publish_date": "1993",
                  "publish_country": "aj",
                  "languages": [
                    {
                      "key": "/languages/rus"
                    }
                  ],
                  "authors": [
                    {
                      "key": "/authors/OL26320A"
                    }
                  ],
                  "work_titles": [
                    "Lord of the rings"
                  ],
                  "notes": "Translation of: The lord of the rings.",
                  "title": "Vlastelin kolet͡s",
                  "by_statement": "Dzhon R.R. Tolkien",
                  "publishers": [
                    "Kont͡sern \"Olimp\""
                  ],
                  "publish_places": [
                    "Baku"
                  ],
                  "pagination": "3 volumes in 2.",
                  "source_records": [
                    "ia:vlastelinkolets0000tolk"
                  ],
                  "full_title": "Vlastelin kolet͡s",
                  "covers": [
                    -1
                  ],
                  "works": [
                    {
                      "key": "/works/OL27448W"
                    }
                  ],
                  "key": "/books/OL37015716M",
                  "identifiers": {},
                  "isbn_10": [
                    "5878600137",
                    "5878600145"
                  ],
                  "isbn_13": [
                    "9785878600132",
                    "9785878600149"
                  ],
                  "oclc_numbers": [
                    "36422414"
                  ],
                  "classifications": {},
                  "latest_revision": 9,
                  "revision": 9,
                  "created": {
                    "type": "/type/datetime",
                    "value": "2022-01-30T04:56:36.675052"
                  },
                  "last_modified": {
                    "type": "/type/datetime",
                    "value": "2024-05-14T15:00:02.840096"
                  }
                }
              ]
            }
            """;
    }
}
