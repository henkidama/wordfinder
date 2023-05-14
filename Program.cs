namespace WordExercise;
public class Program
{
    public static void Main(string []args)
    {
        Console.WriteLine("-----------START-----------");
        #region matrix
        var matrix = new string [] 
        {
            "cpihvyopieocnuksuhhhkjvjzvpcgjsluuytqtdgzjrgqgmqur",
            "sibwaahowbyovxskawwyegkqiclisecilxeeahftnxfueyxsss",
            "vuazisizmbyjifgdxjgfyfbpkrrbxuskhzniwfvhwindusmzan",
            "rduspisnvjrlhirsuocdvjtryxvuytuzkbmqfqxrnrwawqjriz",
            "cxitumvlgrewcfstybskzkrqwqllscxpegzbppmeerpcejdmyc",
            "animalnhmcwesvbvfblsmzwtskulenhcmkdwfcsexffpltphwh",
            "tlhrnxgxjeikcoldazpbjmeylmjsggtoncbdvcgstzlntkkdrr",
            "hqdoibpnpbnagsgqubfuizbxrfqxlihjdogcmpzgwguarantee",
            "vusdmgrimkdkjanngmoijdvhsrnxatbpaldumdbsxpqqjhsguj",
            "ivjsauhujdeemahqrqrrvdslmyakzffqrdcarvwoekewwindks",
            "uclllgqzbqsaznhnwidgkwjdwbmzdjqleyiinqifkeyeslgyhk",
            "yjmhyxawuvovrkftcginogrhiiabzloqpnlheznszrrgbvmece",
            "jkukrzpdpxcccpwmpqeadivevcyopksfqekzjbdbofsuuacycx",
            "xggtwozecoiblifomeyesrhokbhenzlslfqvbkmlabdajqzscd",
            "pbrpgxmwwnicnberlgwfkrgcatyvfgypcgxaedxqemyrgskmpf",
            "xpkojxfnranimalxpzquipsojpdrflwbocoldcsceajauwnatr",
            "pcgpkvnfqjdbinmjpvmtmchgwfcjwioolgjtmevmpnpnjvoqza",
            "nruvizfpiayxiifqewfguaranteekvnfwjdfptgymiatblvlvh",
            "iaazighayilhjmuavdznifkphmkpbreoftdtthreemeebfdkaf",
            "ehrrhbdxpguaranteesqmeuwvrttrwxrbamlhyyhvapeilhjby",
            "xhawsazfhzqxyloumjtixfyzdlhaunlujkdgrywnelebuextag",
            "btnmyplghbftshtcrbnogebkzlzfcqvmokboeyesuucatwpcvl",
            "mmtdgwjurwagcmavqjsewygtiouafvrvuvrberkgicdtbhnbnu",
            "moezamapuxvdxvoutptrmjdlhddfjpxkrdkbbetlokohifrvlc",
            "zceewevemvoffdogozwuitresikmsseranfcsapfqygupziwtk",
            "opxreqgcyreyesnrxporlolqxhbmgqlcfwoukgxmspmqnxtsay",
            "kryvmfktxkaklgeookustrmaiprwrmujpirjduycgliyikqcxe",
            "piopwxmaanrrlerhzkzajizijdfsppwchgcelcqnilloaiimaw",
            "tuflvwwtmpidqeyescrvqhotpohbtowgiiazojkdjlbfraxzih",
            "catrtscjaajyayykiyowuymzugfojjaczjtynxwomjjtdahqja",
            "knjdhsskbdrzdeuhrcatraxjgucqpkgnrpzifouaeeuzclzsmx",
            "rjzbifpxaofhqslnanaodnpzuxcftjnzewbmddtwtbcloxwxuu",
            "dicedufblgdhxtbvmdepwtapaxsgmfrakfrjoaluckyfcjiktm",
            "ugtppamrllylbsflfnkzufxcryyjeajsesobglbujjgyasqgks",
            "guczfzdxdujjtorkmlvboltiamabnjyfdtvoovmrfkzvyalnyq",
            "odaupdecjizkcicoqtwalppbnchkajoiqfcpttqkzyjlaogjdk",
            "kctdcoldioguoqjdfvjwwexxtjpkfirzxaiwalvglmfiejudqx",
            "tgxpygxniccoldhfncjyitmuetuglnryaeqnalgcnrsdpcatqm",
            "mmmayvllqpfodethqylfmebzeviutpsvdyvcplforxzamkrddh",
            "gbsmycnpdwcvwjcjxgnpstmjewwanimaleaahfgccfzetyamqe",
            "xoxgohvdmzynbrztcnimdbhelgerwilnusmtjathoieqogndod",
            "mmzdcrksdzpxqnwindqqbsnsiqxanzwizrnerdcxdkbzcatddo",
            "rxrovlammvwvgihfqjqmkdvlarjnbksmsfqhkjwrxwgimlemii",
            "elygigexqgzyjsqtorgztoblzoetxamagxavfffcvswweyesyz",
            "ycgemmpluckyijwfyloglkxrjypeyiklejnngcqtaxaxeyesvv",
            "envcnuwdeoqnboxepmkwwmwwdiselnnjzpnuazelsoryymksfb",
            "sueeohuwyanxplwrmgktoqgqmcbugfmisgwlzvatncldlykhat",
            "guaranteewrkwlvfdpdsagpgirywhahlwuqczuvynhioxzaydv",
            "hvdjgmvcstgjiarclqymuzsiktnjldmdzarmhtyjzpzgilbtsh",
            "sapynkyhakntwuleyhnkdlsyytcovaqirxojahzkrrvozqyabl"
        };
        #endregion

        var words = new string[]
        {
             "a",
             "eyes",
             "cat",
             "dog",
             "three",
             "two",
             "next",
             "cold",
             "wind",
             "lucky",
             "for",
             "one",
             "animal",
             "guarantee"
        };

        var objFinder = new WordFinder(matrix);

        var result = objFinder.Find(words);

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("-----------END-----------");
    }
}