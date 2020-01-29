using System;
using System.IO;
using System.Net;

namespace MAServer
{
    class Response
    {

        public String Http_Version { get; set; }
        public String Status_Code { get; set; }
        public String Reason_Phrase { get; set; }
        public String Date { get; set; }
        public String Server_Name { get; set; }
        public String Last_Modified { get; set; }
        public String Content_Length { get; set; }
        public String Content_Type { get; set; }
        public String Content_Disposition { get; set; }
        public String Connection { get; set; }

        public Byte[] HtmlPage;

        public Byte[] Data;

        public Response(String http_version, String status_code, String reason_phrase, String date, String server, String last_modified, String content_length, String content_type, String content_disposition, String connection, Byte[] htmlPage, Byte[] data)
        {
            this.Http_Version = http_version;
            this.Status_Code = status_code;
            this.Reason_Phrase = reason_phrase;
            this.Date = date;
            this.Server_Name = server;
            this.Last_Modified = last_modified;
            this.Content_Length = content_length;
            this.Content_Type = content_type;
            this.Content_Disposition = Content_Disposition;
            this.Connection = connection;
            this.HtmlPage = htmlPage;
            this.Data = data;

        }

        public static String Get_Date()
        {

            DateTime date = DateTime.Now;
            String DayOfWeek = date.DayOfWeek.ToString();
            String Day = date.Day.ToString();
            String Month = GetMonth(date.Month);
            String Year = (date.Year % 100).ToString();
            String[] Time = date.ToUniversalTime().ToString().Split(' ');
            String Date = DayOfWeek + ", " + Day + "-" + Month + "-" + Year + " " + Time[1] + " GMT";
            return Date;
        }
        public static String GetMonth(int Month_Num)
        {

            if (Month_Num == 1) return "Jan";
            else if (Month_Num == 2) return "Feb";
            else if (Month_Num == 3) return "Mar";
            else if (Month_Num == 4) return "Apr";
            else if (Month_Num == 5) return "May";
            else if (Month_Num == 6) return "Jun";
            else if (Month_Num == 7) return "Jul";
            else if (Month_Num == 8) return "Aug";
            else if (Month_Num == 9) return "Sep";
            else if (Month_Num == 10) return "Oct";
            else if (Month_Num == 11) return "Nov";
            else if (Month_Num == 12) return "Dec";
            else return "NotValid";
        }
        public static String Get_Content_Type(FileInfo File)
        {

            if (File.Extension == ".323") return "text/h323";
            else if (File.Extension == ".3g2") return "video/3gpp2";
            else if (File.Extension == ".3gp") return "video/3gpp";
            else if (File.Extension == ".3gp2") return "video/3gpp2";
            else if (File.Extension == ".3gpp") return "video/3gpp";
            else if (File.Extension == ".7z") return "application/x-7z-compressed";
            else if (File.Extension == ".aa") return "audio/audible";
            else if (File.Extension == ".AAC") return "audio/aac";
            else if (File.Extension == ".aaf") return "application/octet-stream";
            else if (File.Extension == ".aax") return "audio/vnd.audible.aax";
            else if (File.Extension == ".ac3") return "audio/ac3";
            else if (File.Extension == ".aca") return "application/octet-stream";
            else if (File.Extension == ".accda") return "application/msaccess.addin";
            else if (File.Extension == ".accdb") return "application/msaccess";
            else if (File.Extension == ".accdc") return "application/msaccess.cab";
            else if (File.Extension == ".accde") return "application/msaccess";
            else if (File.Extension == ".accdr") return "application/msaccess.runtime";
            else if (File.Extension == ".accdt") return "application/msaccess";
            else if (File.Extension == ".accdw") return "application/msaccess.webapplication";
            else if (File.Extension == ".accft") return "application/msaccess.ftemplate";
            else if (File.Extension == ".acx") return "application/internet-property-stream";
            else if (File.Extension == ".AddIn") return "text/xml";
            else if (File.Extension == ".ade") return "application/msaccess";
            else if (File.Extension == ".adobebridge") return "application/x-bridge-url";
            else if (File.Extension == ".adp") return "application/msaccess";
            else if (File.Extension == ".ADT") return "audio/vnd.dlna.adts";
            else if (File.Extension == ".ADTS") return "audio/aac";
            else if (File.Extension == ".afm") return "application/octet-stream";
            else if (File.Extension == ".ai") return "application/postscript";
            else if (File.Extension == ".aif") return "audio/x-aiff";
            else if (File.Extension == ".aifc") return "audio/aiff";
            else if (File.Extension == ".aiff") return "audio/aiff";
            else if (File.Extension == ".air") return "application/vnd.adobe.air-application-installer-package+zip";
            else if (File.Extension == ".amc") return "application/x-mpeg";
            else if (File.Extension == ".application") return "application/x-ms-application";
            else if (File.Extension == ".art") return "image/x-jg";
            else if (File.Extension == ".asa") return "application/xml";
            else if (File.Extension == ".asax") return "application/xml";
            else if (File.Extension == ".ascx") return "application/xml";
            else if (File.Extension == ".asd") return "application/octet-stream";
            else if (File.Extension == ".asf") return "video/x-ms-asf";
            else if (File.Extension == ".ashx") return "application/xml";
            else if (File.Extension == ".asi") return "application/octet-stream";
            else if (File.Extension == ".asm") return "text/plain";
            else if (File.Extension == ".asmx") return "application/xml";
            else if (File.Extension == ".aspx") return "application/xml";
            else if (File.Extension == ".asr") return "video/x-ms-asf";
            else if (File.Extension == ".asx") return "video/x-ms-asf";
            else if (File.Extension == ".atom") return "application/atom+xml";
            else if (File.Extension == ".au") return "audio/basic";
            else if (File.Extension == ".avi") return "video/x-msvideo";
            else if (File.Extension == ".axs") return "application/olescript";
            else if (File.Extension == ".bas") return "text/plain";
            else if (File.Extension == ".bcpio") return "application/x-bcpio";
            else if (File.Extension == ".bin") return "application/octet-stream";
            else if (File.Extension == ".bmp") return "image/bmp";
            else if (File.Extension == ".c") return "text/plain";
            else if (File.Extension == ".cab") return "application/octet-stream";
            else if (File.Extension == ".caf") return "audio/x-caf";
            else if (File.Extension == ".calx") return "application/vnd.ms-office.calx";
            else if (File.Extension == ".cat") return "application/vnd.ms-pki.seccat";
            else if (File.Extension == ".cc") return "text/plain";
            else if (File.Extension == ".cd") return "text/plain";
            else if (File.Extension == ".cdda") return "audio/aiff";
            else if (File.Extension == ".cdf") return "application/x-cdf";
            else if (File.Extension == ".cer") return "application/x-x509-ca-cert";
            else if (File.Extension == ".chm") return "application/octet-stream";
            else if (File.Extension == ".class") return "application/x-java-applet";
            else if (File.Extension == ".clp") return "application/x-msclip";
            else if (File.Extension == ".cmx") return "image/x-cmx";
            else if (File.Extension == ".cnf") return "text/plain";
            else if (File.Extension == ".cod") return "image/cis-cod";
            else if (File.Extension == ".config") return "application/xml";
            else if (File.Extension == ".contact") return "text/x-ms-contact";
            else if (File.Extension == ".coverage") return "application/xml";
            else if (File.Extension == ".cpio") return "application/x-cpio";
            else if (File.Extension == ".cpp") return "text/plain";
            else if (File.Extension == ".crd") return "application/x-mscardfile";
            else if (File.Extension == ".crl") return "application/pkix-crl";
            else if (File.Extension == ".crt") return "application/x-x509-ca-cert";
            else if (File.Extension == ".cs") return "text/plain";
            else if (File.Extension == ".csdproj") return "text/plain";
            else if (File.Extension == ".csh") return "application/x-csh";
            else if (File.Extension == ".csproj") return "text/plain";
            else if (File.Extension == ".css") return "text/css";
            else if (File.Extension == ".csv") return "text/csv";
            else if (File.Extension == ".cur") return "application/octet-stream";
            else if (File.Extension == ".cxx") return "text/plain";
            else if (File.Extension == ".dat") return "application/octet-stream";
            else if (File.Extension == ".datasource") return "application/xml";
            else if (File.Extension == ".dbproj") return "text/plain";
            else if (File.Extension == ".dcr") return "application/x-director";
            else if (File.Extension == ".def") return "text/plain";
            else if (File.Extension == ".deploy") return "application/octet-stream";
            else if (File.Extension == ".der") return "application/x-x509-ca-cert";
            else if (File.Extension == ".dgml") return "application/xml";
            else if (File.Extension == ".dib") return "image/bmp";
            else if (File.Extension == ".dif") return "video/x-dv";
            else if (File.Extension == ".dir") return "application/x-director";
            else if (File.Extension == ".disco") return "text/xml";
            else if (File.Extension == ".dll") return "application/x-msdownload";
            else if (File.Extension == ".dll.config") return "text/xml";
            else if (File.Extension == ".dlm") return "text/dlm";
            else if (File.Extension == ".doc") return "application/msword";
            else if (File.Extension == ".docm") return "application/vnd.ms-word.document.macroEnabled.12";
            else if (File.Extension == ".docx") return "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
            else if (File.Extension == ".dot") return "application/msword";
            else if (File.Extension == ".dotm") return "application/vnd.ms-word.template.macroEnabled.12";
            else if (File.Extension == ".dotx") return "application/vnd.openxmlformats-officedocument.wordprocessingml.template";
            else if (File.Extension == ".dsp") return "application/octet-stream";
            else if (File.Extension == ".dsw") return "text/plain";
            else if (File.Extension == ".dtd") return "text/xml";
            else if (File.Extension == ".dtsConfig") return "text/xml";
            else if (File.Extension == ".dv") return "video/x-dv";
            else if (File.Extension == ".dvi") return "application/x-dvi";
            else if (File.Extension == ".dwf") return "drawing/x-dwf";
            else if (File.Extension == ".dwp") return "application/octet-stream";
            else if (File.Extension == ".dxr") return "application/x-director";
            else if (File.Extension == ".eml") return "message/rfc822";
            else if (File.Extension == ".emz") return "application/octet-stream";
            else if (File.Extension == ".eot") return "application/octet-stream";
            else if (File.Extension == ".eps") return "application/postscript";
            else if (File.Extension == ".etl") return "application/etl";
            else if (File.Extension == ".etx") return "text/x-setext";
            else if (File.Extension == ".evy") return "application/envoy";
            else if (File.Extension == ".exe") return "application/octet-stream";
            else if (File.Extension == ".exe.config") return "text/xml";
            else if (File.Extension == ".fdf") return "application/vnd.fdf";
            else if (File.Extension == ".fif") return "application/fractals";
            else if (File.Extension == ".filters") return "Application/xml";
            else if (File.Extension == ".fla") return "application/octet-stream";
            else if (File.Extension == ".flr") return "x-world/x-vrml";
            else if (File.Extension == ".flv") return "video/x-flv";
            else if (File.Extension == ".fsscript") return "application/fsharp-script";
            else if (File.Extension == ".fsx") return "application/fsharp-script";
            else if (File.Extension == ".generictest") return "application/xml";
            else if (File.Extension == ".gif") return "image/gif";
            else if (File.Extension == ".group") return "text/x-ms-group";
            else if (File.Extension == ".gsm") return "audio/x-gsm";
            else if (File.Extension == ".gtar") return "application/x-gtar";
            else if (File.Extension == ".gz") return "application/x-gzip";
            else if (File.Extension == ".h") return "text/plain";
            else if (File.Extension == ".hdf") return "application/x-hdf";
            else if (File.Extension == ".hdml") return "text/x-hdml";
            else if (File.Extension == ".hhc") return "application/x-oleobject";
            else if (File.Extension == ".hhk") return "application/octet-stream";
            else if (File.Extension == ".hhp") return "application/octet-stream";
            else if (File.Extension == ".hlp") return "application/winhlp";
            else if (File.Extension == ".hpp") return "text/plain";
            else if (File.Extension == ".hqx") return "application/mac-binhex40";
            else if (File.Extension == ".hta") return "application/hta";
            else if (File.Extension == ".htc") return "text/x-component";
            else if (File.Extension == ".htm") return "text/html";
            else if (File.Extension == ".html") return "text/html";
            else if (File.Extension == ".htt") return "text/webviewhtml";
            else if (File.Extension == ".hxa") return "application/xml";
            else if (File.Extension == ".hxc") return "application/xml";
            else if (File.Extension == ".hxd") return "application/octet-stream";
            else if (File.Extension == ".hxe") return "application/xml";
            else if (File.Extension == ".hxf") return "application/xml";
            else if (File.Extension == ".hxh") return "application/octet-stream";
            else if (File.Extension == ".hxi") return "application/octet-stream";
            else if (File.Extension == ".hxk") return "application/xml";
            else if (File.Extension == ".hxq") return "application/octet-stream";
            else if (File.Extension == ".hxr") return "application/octet-stream";
            else if (File.Extension == ".hxs") return "application/octet-stream";
            else if (File.Extension == ".hxt") return "text/html";
            else if (File.Extension == ".hxv") return "application/xml";
            else if (File.Extension == ".hxw") return "application/octet-stream";
            else if (File.Extension == ".hxx") return "text/plain";
            else if (File.Extension == ".i") return "text/plain";
            else if (File.Extension == ".ico") return "image/x-icon";
            else if (File.Extension == ".ics") return "application/octet-stream";
            else if (File.Extension == ".idl") return "text/plain";
            else if (File.Extension == ".ief") return "image/ief";
            else if (File.Extension == ".iii") return "application/x-iphone";
            else if (File.Extension == ".inc") return "text/plain";
            else if (File.Extension == ".inf") return "application/octet-stream";
            else if (File.Extension == ".inl") return "text/plain";
            else if (File.Extension == ".ins") return "application/x-internet-signup";
            else if (File.Extension == ".ipa") return "application/x-itunes-ipa";
            else if (File.Extension == ".ipg") return "application/x-itunes-ipg";
            else if (File.Extension == ".ipproj") return "text/plain";
            else if (File.Extension == ".ipsw") return "application/x-itunes-ipsw";
            else if (File.Extension == ".iqy") return "text/x-ms-iqy";
            else if (File.Extension == ".isp") return "application/x-internet-signup";
            else if (File.Extension == ".ite") return "application/x-itunes-ite";
            else if (File.Extension == ".itlp") return "application/x-itunes-itlp";
            else if (File.Extension == ".itms") return "application/x-itunes-itms";
            else if (File.Extension == ".itpc") return "application/x-itunes-itpc";
            else if (File.Extension == ".IVF") return "video/x-ivf";
            else if (File.Extension == ".jar") return "application/java-archive";
            else if (File.Extension == ".java") return "application/octet-stream";
            else if (File.Extension == ".jck") return "application/liquidmotion";
            else if (File.Extension == ".jcz") return "application/liquidmotion";
            else if (File.Extension == ".jfif") return "image/pjpeg";
            else if (File.Extension == ".jnlp") return "application/x-java-jnlp-file";
            else if (File.Extension == ".jpb") return "application/octet-stream";
            else if (File.Extension == ".jpe") return "image/jpeg";
            else if (File.Extension == ".jpeg") return "image/jpeg";
            else if (File.Extension == ".jpg") return "image/jpeg";
            else if (File.Extension == ".js") return "application/x-javascript";
            else if (File.Extension == ".json") return "application/json";
            else if (File.Extension == ".jsx") return "text/jscript";
            else if (File.Extension == ".jsxbin") return "text/plain";
            else if (File.Extension == ".latex") return "application/x-latex";
            else if (File.Extension == ".library-ms") return "application/windows-library+xml";
            else if (File.Extension == ".lit") return "application/x-ms-reader";
            else if (File.Extension == ".loadtest") return "application/xml";
            else if (File.Extension == ".lpk") return "application/octet-stream";
            else if (File.Extension == ".lsf") return "video/x-la-asf";
            else if (File.Extension == ".lst") return "text/plain";
            else if (File.Extension == ".lsx") return "video/x-la-asf";
            else if (File.Extension == ".lzh") return "application/octet-stream";
            else if (File.Extension == ".m13") return "application/x-msmediaview";
            else if (File.Extension == ".m14") return "application/x-msmediaview";
            else if (File.Extension == ".m1v") return "video/mpeg";
            else if (File.Extension == ".m2t") return "video/vnd.dlna.mpeg-tts";
            else if (File.Extension == ".m2ts") return "video/vnd.dlna.mpeg-tts";
            else if (File.Extension == ".m2v") return "video/mpeg";
            else if (File.Extension == ".m3u") return "audio/x-mpegurl";
            else if (File.Extension == ".m3u8") return "audio/x-mpegurl";
            else if (File.Extension == ".m4a") return "audio/m4a";
            else if (File.Extension == ".m4b") return "audio/m4b";
            else if (File.Extension == ".m4p") return "audio/m4p";
            else if (File.Extension == ".m4r") return "audio/x-m4r";
            else if (File.Extension == ".m4v") return "video/x-m4v";
            else if (File.Extension == ".mac") return "image/x-macpaint";
            else if (File.Extension == ".mak") return "text/plain";
            else if (File.Extension == ".man") return "application/x-troff-man";
            else if (File.Extension == ".manifest") return "application/x-ms-manifest";
            else if (File.Extension == ".map") return "text/plain";
            else if (File.Extension == ".master") return "application/xml";
            else if (File.Extension == ".mda") return "application/msaccess";
            else if (File.Extension == ".mdb") return "application/x-msaccess";
            else if (File.Extension == ".mde") return "application/msaccess";
            else if (File.Extension == ".mdp") return "application/octet-stream";
            else if (File.Extension == ".me") return "application/x-troff-me";
            else if (File.Extension == ".mfp") return "application/x-shockwave-flash";
            else if (File.Extension == ".mht") return "message/rfc822";
            else if (File.Extension == ".mhtml") return "message/rfc822";
            else if (File.Extension == ".mid") return "audio/mid";
            else if (File.Extension == ".midi") return "audio/mid";
            else if (File.Extension == ".mix") return "application/octet-stream";
            else if (File.Extension == ".mkv") return "video/mkv";
            else if (File.Extension == ".mmf") return "application/x-smaf";
            else if (File.Extension == ".mno") return "text/xml";
            else if (File.Extension == ".mny") return "application/x-msmoney";
            else if (File.Extension == ".mod") return "video/mpeg";
            else if (File.Extension == ".mov") return "video/quicktime";
            else if (File.Extension == ".movie") return "video/x-sgi-movie";
            else if (File.Extension == ".mp2") return "video/mpeg";
            else if (File.Extension == ".mp2v") return "video/mpeg";
            else if (File.Extension == ".mp3") return "audio/mpeg";
            else if (File.Extension == ".mp4") return "video/mp4";
            else if (File.Extension == ".mp4v") return "video/mp4";
            else if (File.Extension == ".mpa") return "video/mpeg";
            else if (File.Extension == ".mpe") return "video/mpeg";
            else if (File.Extension == ".mpeg") return "video/mpeg";
            else if (File.Extension == ".mpf") return "application/vnd.ms-mediapackage";
            else if (File.Extension == ".mpg") return "video/mpeg";
            else if (File.Extension == ".mpp") return "application/vnd.ms-project";
            else if (File.Extension == ".mpv2") return "video/mpeg";
            else if (File.Extension == ".mqv") return "video/quicktime";
            else if (File.Extension == ".ms") return "application/x-troff-ms";
            else if (File.Extension == ".msi") return "application/octet-stream";
            else if (File.Extension == ".mso") return "application/octet-stream";
            else if (File.Extension == ".mts") return "video/vnd.dlna.mpeg-tts";
            else if (File.Extension == ".mtx") return "application/xml";
            else if (File.Extension == ".mvb") return "application/x-msmediaview";
            else if (File.Extension == ".mvc") return "application/x-miva-compiled";
            else if (File.Extension == ".mxp") return "application/x-mmxp";
            else if (File.Extension == ".nc") return "application/x-netcdf";
            else if (File.Extension == ".nsc") return "video/x-ms-asf";
            else if (File.Extension == ".nws") return "message/rfc822";
            else if (File.Extension == ".ocx") return "application/octet-stream";
            else if (File.Extension == ".oda") return "application/oda";
            else if (File.Extension == ".odc") return "text/x-ms-odc";
            else if (File.Extension == ".odh") return "text/plain";
            else if (File.Extension == ".odl") return "text/plain";
            else if (File.Extension == ".odp") return "application/vnd.oasis.opendocument.presentation";
            else if (File.Extension == ".ods") return "application/oleobject";
            else if (File.Extension == ".odt") return "application/vnd.oasis.opendocument.text";
            else if (File.Extension == ".one") return "application/onenote";
            else if (File.Extension == ".onea") return "application/onenote";
            else if (File.Extension == ".onepkg") return "application/onenote";
            else if (File.Extension == ".onetmp") return "application/onenote";
            else if (File.Extension == ".onetoc") return "application/onenote";
            else if (File.Extension == ".onetoc2") return "application/onenote";
            else if (File.Extension == ".orderedtest") return "application/xml";
            else if (File.Extension == ".osdx") return "application/opensearchdescription+xml";
            else if (File.Extension == ".p10") return "application/pkcs10";
            else if (File.Extension == ".p12") return "application/x-pkcs12";
            else if (File.Extension == ".p7b") return "application/x-pkcs7-certificates";
            else if (File.Extension == ".p7c") return "application/pkcs7-mime";
            else if (File.Extension == ".p7m") return "application/pkcs7-mime";
            else if (File.Extension == ".p7r") return "application/x-pkcs7-certreqresp";
            else if (File.Extension == ".p7s") return "application/pkcs7-signature";
            else if (File.Extension == ".pbm") return "image/x-portable-bitmap";
            else if (File.Extension == ".pcast") return "application/x-podcast";
            else if (File.Extension == ".pct") return "image/pict";
            else if (File.Extension == ".pcx") return "application/octet-stream";
            else if (File.Extension == ".pcz") return "application/octet-stream";
            else if (File.Extension == ".pdf") return "application/pdf";
            else if (File.Extension == ".pfb") return "application/octet-stream";
            else if (File.Extension == ".pfm") return "application/octet-stream";
            else if (File.Extension == ".pfx") return "application/x-pkcs12";
            else if (File.Extension == ".pgm") return "image/x-portable-graymap";
            else if (File.Extension == ".pic") return "image/pict";
            else if (File.Extension == ".pict") return "image/pict";
            else if (File.Extension == ".pkgdef") return "text/plain";
            else if (File.Extension == ".pkgundef") return "text/plain";
            else if (File.Extension == ".pko") return "application/vnd.ms-pki.pko";
            else if (File.Extension == ".pls") return "audio/scpls";
            else if (File.Extension == ".pma") return "application/x-perfmon";
            else if (File.Extension == ".pmc") return "application/x-perfmon";
            else if (File.Extension == ".pml") return "application/x-perfmon";
            else if (File.Extension == ".pmr") return "application/x-perfmon";
            else if (File.Extension == ".pmw") return "application/x-perfmon";
            else if (File.Extension == ".png") return "image/png";
            else if (File.Extension == ".pnm") return "image/x-portable-anymap";
            else if (File.Extension == ".pnt") return "image/x-macpaint";
            else if (File.Extension == ".pntg") return "image/x-macpaint";
            else if (File.Extension == ".pnz") return "image/png";
            else if (File.Extension == ".pot") return "application/vnd.ms-powerpoint";
            else if (File.Extension == ".potm") return "application/vnd.ms-powerpoint.template.macroEnabled.12";
            else if (File.Extension == ".potx") return "application/vnd.openxmlformats-officedocument.presentationml.template";
            else if (File.Extension == ".ppa") return "application/vnd.ms-powerpoint";
            else if (File.Extension == ".ppam") return "application/vnd.ms-powerpoint.addin.macroEnabled.12";
            else if (File.Extension == ".ppm") return "image/x-portable-pixmap";
            else if (File.Extension == ".pps") return "application/vnd.ms-powerpoint";
            else if (File.Extension == ".ppsm") return "application/vnd.ms-powerpoint.slideshow.macroEnabled.12";
            else if (File.Extension == ".ppsx") return "application/vnd.openxmlformats-officedocument.presentationml.slideshow";
            else if (File.Extension == ".ppt") return "application/vnd.ms-powerpoint";
            else if (File.Extension == ".pptm") return "application/vnd.ms-powerpoint.presentation.macroEnabled.12";
            else if (File.Extension == ".pptx") return "application/vnd.openxmlformats-officedocument.presentationml.presentation";
            else if (File.Extension == ".prf") return "application/pics-rules";
            else if (File.Extension == ".prm") return "application/octet-stream";
            else if (File.Extension == ".prx") return "application/octet-stream";
            else if (File.Extension == ".ps") return "application/postscript";
            else if (File.Extension == ".psc1") return "application/PowerShell";
            else if (File.Extension == ".psd") return "application/octet-stream";
            else if (File.Extension == ".psess") return "application/xml";
            else if (File.Extension == ".psm") return "application/octet-stream";
            else if (File.Extension == ".psp") return "application/octet-stream";
            else if (File.Extension == ".pub") return "application/x-mspublisher";
            else if (File.Extension == ".pwz") return "application/vnd.ms-powerpoint";
            else if (File.Extension == ".qht") return "text/x-html-insertion";
            else if (File.Extension == ".qhtm") return "text/x-html-insertion";
            else if (File.Extension == ".qt") return "video/quicktime";
            else if (File.Extension == ".qti") return "image/x-quicktime";
            else if (File.Extension == ".qtif") return "image/x-quicktime";
            else if (File.Extension == ".qtl") return "application/x-quicktimeplayer";
            else if (File.Extension == ".qxd") return "application/octet-stream";
            else if (File.Extension == ".ra") return "audio/x-pn-realaudio";
            else if (File.Extension == ".ram") return "audio/x-pn-realaudio";
            else if (File.Extension == ".rar") return "application/octet-stream";
            else if (File.Extension == ".ras") return "image/x-cmu-raster";
            else if (File.Extension == ".rat") return "application/rat-file";
            else if (File.Extension == ".rc") return "text/plain";
            else if (File.Extension == ".rc2") return "text/plain";
            else if (File.Extension == ".rct") return "text/plain";
            else if (File.Extension == ".rdlc") return "application/xml";
            else if (File.Extension == ".resx") return "application/xml";
            else if (File.Extension == ".rf") return "image/vnd.rn-realflash";
            else if (File.Extension == ".rgb") return "image/x-rgb";
            else if (File.Extension == ".rgs") return "text/plain";
            else if (File.Extension == ".rm") return "application/vnd.rn-realmedia";
            else if (File.Extension == ".rmi") return "audio/mid";
            else if (File.Extension == ".rmp") return "application/vnd.rn-rn_music_package";
            else if (File.Extension == ".roff") return "application/x-troff";
            else if (File.Extension == ".rpm") return "audio/x-pn-realaudio-plugin";
            else if (File.Extension == ".rqy") return "text/x-ms-rqy";
            else if (File.Extension == ".rtf") return "application/rtf";
            else if (File.Extension == ".rtx") return "text/richtext";
            else if (File.Extension == ".ruleset") return "application/xml";
            else if (File.Extension == ".s") return "text/plain";
            else if (File.Extension == ".safariextz") return "application/x-safari-safariextz";
            else if (File.Extension == ".scd") return "application/x-msschedule";
            else if (File.Extension == ".sct") return "text/scriptlet";
            else if (File.Extension == ".sd2") return "audio/x-sd2";
            else if (File.Extension == ".sdp") return "application/sdp";
            else if (File.Extension == ".sea") return "application/octet-stream";
            else if (File.Extension == ".searchConnector-ms") return "application/windows-search-connector+xml";
            else if (File.Extension == ".setpay") return "application/set-payment-initiation";
            else if (File.Extension == ".setreg") return "application/set-registration-initiation";
            else if (File.Extension == ".settings") return "application/xml";
            else if (File.Extension == ".sgimb") return "application/x-sgimb";
            else if (File.Extension == ".sgml") return "text/sgml";
            else if (File.Extension == ".sh") return "application/x-sh";
            else if (File.Extension == ".shar") return "application/x-shar";
            else if (File.Extension == ".shtml") return "text/html";
            else if (File.Extension == ".sit") return "application/x-stuffit";
            else if (File.Extension == ".sitemap") return "application/xml";
            else if (File.Extension == ".skin") return "application/xml";
            else if (File.Extension == ".sldm") return "application/vnd.ms-powerpoint.slide.macroEnabled.12";
            else if (File.Extension == ".sldx") return "application/vnd.openxmlformats-officedocument.presentationml.slide";
            else if (File.Extension == ".slk") return "application/vnd.ms-excel";
            else if (File.Extension == ".sln") return "text/plain";
            else if (File.Extension == ".slupkg-ms") return "application/x-ms-license";
            else if (File.Extension == ".smd") return "audio/x-smd";
            else if (File.Extension == ".smi") return "application/octet-stream";
            else if (File.Extension == ".smx") return "audio/x-smd";
            else if (File.Extension == ".smz") return "audio/x-smd";
            else if (File.Extension == ".snd") return "audio/basic";
            else if (File.Extension == ".snippet") return "application/xml";
            else if (File.Extension == ".snp") return "application/octet-stream";
            else if (File.Extension == ".sol") return "text/plain";
            else if (File.Extension == ".sor") return "text/plain";
            else if (File.Extension == ".spc") return "application/x-pkcs7-certificates";
            else if (File.Extension == ".spl") return "application/futuresplash";
            else if (File.Extension == ".src") return "application/x-wais-source";
            else if (File.Extension == ".srf") return "text/plain";
            else if (File.Extension == ".SSISDeploymentManifest") return "text/xml";
            else if (File.Extension == ".ssm") return "application/streamingmedia";
            else if (File.Extension == ".sst") return "application/vnd.ms-pki.certstore";
            else if (File.Extension == ".stl") return "application/vnd.ms-pki.stl";
            else if (File.Extension == ".sv4cpio") return "application/x-sv4cpio";
            else if (File.Extension == ".sv4crc") return "application/x-sv4crc";
            else if (File.Extension == ".svc") return "application/xml";
            else if (File.Extension == ".swf") return "application/x-shockwave-flash";
            else if (File.Extension == ".t") return "application/x-troff";
            else if (File.Extension == ".tar") return "application/x-tar";
            else if (File.Extension == ".tcl") return "application/x-tcl";
            else if (File.Extension == ".testrunconfig") return "application/xml";
            else if (File.Extension == ".testsettings") return "application/xml";
            else if (File.Extension == ".tex") return "application/x-tex";
            else if (File.Extension == ".texi") return "application/x-texinfo";
            else if (File.Extension == ".texinfo") return "application/x-texinfo";
            else if (File.Extension == ".tgz") return "application/x-compressed";
            else if (File.Extension == ".thmx") return "application/vnd.ms-officetheme";
            else if (File.Extension == ".thn") return "application/octet-stream";
            else if (File.Extension == ".tif") return "image/tiff";
            else if (File.Extension == ".tiff") return "image/tiff";
            else if (File.Extension == ".tlh") return "text/plain";
            else if (File.Extension == ".tli") return "text/plain";
            else if (File.Extension == ".toc") return "application/octet-stream";
            else if (File.Extension == ".tr") return "application/x-troff";
            else if (File.Extension == ".trm") return "application/x-msterminal";
            else if (File.Extension == ".trx") return "application/xml";
            else if (File.Extension == ".ts") return "video/vnd.dlna.mpeg-tts";
            else if (File.Extension == ".tsv") return "text/tab-separated-values";
            else if (File.Extension == ".ttf") return "application/octet-stream";
            else if (File.Extension == ".tts") return "video/vnd.dlna.mpeg-tts";
            else if (File.Extension == ".txt") return "text/plain";
            else if (File.Extension == ".u32") return "application/octet-stream";
            else if (File.Extension == ".uls") return "text/iuls";
            else if (File.Extension == ".user") return "text/plain";
            else if (File.Extension == ".ustar") return "application/x-ustar";
            else if (File.Extension == ".vb") return "text/plain";
            else if (File.Extension == ".vbdproj") return "text/plain";
            else if (File.Extension == ".vbk") return "video/mpeg";
            else if (File.Extension == ".vbproj") return "text/plain";
            else if (File.Extension == ".vbs") return "text/vbscript";
            else if (File.Extension == ".vcf") return "text/x-vcard";
            else if (File.Extension == ".vcproj") return "Application/xml";
            else if (File.Extension == ".vcs") return "text/plain";
            else if (File.Extension == ".vcxproj") return "Application/xml";
            else if (File.Extension == ".vddproj") return "text/plain";
            else if (File.Extension == ".vdp") return "text/plain";
            else if (File.Extension == ".vdproj") return "text/plain";
            else if (File.Extension == ".vdx") return "application/vnd.ms-visio.viewer";
            else if (File.Extension == ".vml") return "text/xml";
            else if (File.Extension == ".vscontent") return "application/xml";
            else if (File.Extension == ".vsct") return "text/xml";
            else if (File.Extension == ".vsd") return "application/vnd.visio";
            else if (File.Extension == ".vsi") return "application/ms-vsi";
            else if (File.Extension == ".vsix") return "application/vsix";
            else if (File.Extension == ".vsixlangpack") return "text/xml";
            else if (File.Extension == ".vsixmanifest") return "text/xml";
            else if (File.Extension == ".vsmdi") return "application/xml";
            else if (File.Extension == ".vspscc") return "text/plain";
            else if (File.Extension == ".vss") return "application/vnd.visio";
            else if (File.Extension == ".vsscc") return "text/plain";
            else if (File.Extension == ".vssettings") return "text/xml";
            else if (File.Extension == ".vssscc") return "text/plain";
            else if (File.Extension == ".vst") return "application/vnd.visio";
            else if (File.Extension == ".vstemplate") return "text/xml";
            else if (File.Extension == ".vsto") return "application/x-ms-vsto";
            else if (File.Extension == ".vsw") return "application/vnd.visio";
            else if (File.Extension == ".vsx") return "application/vnd.visio";
            else if (File.Extension == ".vtx") return "application/vnd.visio";
            else if (File.Extension == ".wav") return "audio/wav";
            else if (File.Extension == ".wave") return "audio/wav";
            else if (File.Extension == ".wax") return "audio/x-ms-wax";
            else if (File.Extension == ".wbk") return "application/msword";
            else if (File.Extension == ".wbmp") return "image/vnd.wap.wbmp";
            else if (File.Extension == ".wcm") return "application/vnd.ms-works";
            else if (File.Extension == ".wdb") return "application/vnd.ms-works";
            else if (File.Extension == ".wdp") return "image/vnd.ms-photo";
            else if (File.Extension == ".webarchive") return "application/x-safari-webarchive";
            else if (File.Extension == ".webtest") return "application/xml";
            else if (File.Extension == ".wiq") return "application/xml";
            else if (File.Extension == ".wiz") return "application/msword";
            else if (File.Extension == ".wks") return "application/vnd.ms-works";
            else if (File.Extension == ".WLMP") return "application/wlmoviemaker";
            else if (File.Extension == ".wlpginstall") return "application/x-wlpg-detect";
            else if (File.Extension == ".wlpginstall3") return "application/x-wlpg3-detect";
            else if (File.Extension == ".wm") return "video/x-ms-wm";
            else if (File.Extension == ".wma") return "audio/x-ms-wma";
            else if (File.Extension == ".wmd") return "application/x-ms-wmd";
            else if (File.Extension == ".wmf") return "application/x-msmetafile";
            else if (File.Extension == ".wml") return "text/vnd.wap.wml";
            else if (File.Extension == ".wmlc") return "application/vnd.wap.wmlc";
            else if (File.Extension == ".wmls") return "text/vnd.wap.wmlscript";
            else if (File.Extension == ".wmlsc") return "application/vnd.wap.wmlscriptc";
            else if (File.Extension == ".wmp") return "video/x-ms-wmp";
            else if (File.Extension == ".wmv") return "video/x-ms-wmv";
            else if (File.Extension == ".wmx") return "video/x-ms-wmx";
            else if (File.Extension == ".wmz") return "application/x-ms-wmz";
            else if (File.Extension == ".wpl") return "application/vnd.ms-wpl";
            else if (File.Extension == ".wps") return "application/vnd.ms-works";
            else if (File.Extension == ".wri") return "application/x-mswrite";
            else if (File.Extension == ".wrl") return "x-world/x-vrml";
            else if (File.Extension == ".wrz") return "x-world/x-vrml";
            else if (File.Extension == ".wsc") return "text/scriptlet";
            else if (File.Extension == ".wsdl") return "text/xml";
            else if (File.Extension == ".wvx") return "video/x-ms-wvx";
            else if (File.Extension == ".x") return "application/directx";
            else if (File.Extension == ".xaf") return "x-world/x-vrml";
            else if (File.Extension == ".xaml") return "application/xaml+xml";
            else if (File.Extension == ".xap") return "application/x-silverlight-app";
            else if (File.Extension == ".xbap") return "application/x-ms-xbap";
            else if (File.Extension == ".xbm") return "image/x-xbitmap";
            else if (File.Extension == ".xdr") return "text/plain";
            else if (File.Extension == ".xht") return "application/xhtml+xml";
            else if (File.Extension == ".xhtml") return "application/xhtml+xml";
            else if (File.Extension == ".xla") return "application/vnd.ms-excel";
            else if (File.Extension == ".xlam") return "application/vnd.ms-excel.addin.macroEnabled.12";
            else if (File.Extension == ".xlc") return "application/vnd.ms-excel";
            else if (File.Extension == ".xld") return "application/vnd.ms-excel";
            else if (File.Extension == ".xlk") return "application/vnd.ms-excel";
            else if (File.Extension == ".xll") return "application/vnd.ms-excel";
            else if (File.Extension == ".xlm") return "application/vnd.ms-excel";
            else if (File.Extension == ".xls") return "application/vnd.ms-excel";
            else if (File.Extension == ".xlsb") return "application/vnd.ms-excel.sheet.binary.macroEnabled.12";
            else if (File.Extension == ".xlsm") return "application/vnd.ms-excel.sheet.macroEnabled.12";
            else if (File.Extension == ".xlsx") return "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            else if (File.Extension == ".xlt") return "application/vnd.ms-excel";
            else if (File.Extension == ".xltm") return "application/vnd.ms-excel.template.macroEnabled.12";
            else if (File.Extension == ".xltx") return "application/vnd.openxmlformats-officedocument.spreadsheetml.template";
            else if (File.Extension == ".xlw") return "application/vnd.ms-excel";
            else if (File.Extension == ".xml") return "text/xml";
            else if (File.Extension == ".xmta") return "application/xml";
            else if (File.Extension == ".xof") return "x-world/x-vrml";
            else if (File.Extension == ".XOML") return "text/plain";
            else if (File.Extension == ".xpm") return "image/x-xpixmap";
            else if (File.Extension == ".xps") return "application/vnd.ms-xpsdocument";
            else if (File.Extension == ".xrm-ms") return "text/xml";
            else if (File.Extension == ".xsc") return "application/xml";
            else if (File.Extension == ".xsd") return "text/xml";
            else if (File.Extension == ".xsf") return "text/xml";
            else if (File.Extension == ".xsl") return "text/xml";
            else if (File.Extension == ".xslt") return "text/xml";
            else if (File.Extension == ".xsn") return "application/octet-stream";
            else if (File.Extension == ".xss") return "application/xml";
            else if (File.Extension == ".xtp") return "application/octet-stream";
            else if (File.Extension == ".xwd") return "image/x-xwindowdump";
            else if (File.Extension == ".z") return "application/x-compress";
            else if (File.Extension == ".zip") return "application/x-zip-compressed";
            else return "text/plain";

        }
        public static String Get_Reason_Phrase(String Status_Code)
        {

            if (Status_Code.Equals("100")) return "Continue";
            else if (Status_Code.Equals("101")) return "Switching Protocols";
            else if (Status_Code.Equals("200")) return "OK";
            else if (Status_Code.Equals("201")) return "Created";
            else if (Status_Code.Equals("202")) return "Accepted";
            else if (Status_Code.Equals("203")) return "Non-Authoritative Information";
            else if (Status_Code.Equals("204")) return "No Content";
            else if (Status_Code.Equals("205")) return "Reset Content";
            else if (Status_Code.Equals("206")) return "Partial Content";
            else if (Status_Code.Equals("300")) return "Multiple Choices";
            else if (Status_Code.Equals("301")) return "Moved Permanently";
            else if (Status_Code.Equals("302")) return "Found";
            else if (Status_Code.Equals("303")) return "See Other";
            else if (Status_Code.Equals("304")) return "Not Modified";
            else if (Status_Code.Equals("305")) return "Use Proxy";
            else if (Status_Code.Equals("307")) return "Temporary Redirect";
            else if (Status_Code.Equals("400")) return "Bad Request";
            else if (Status_Code.Equals("401")) return "Unauthorized";
            else if (Status_Code.Equals("402")) return "Payment Required";
            else if (Status_Code.Equals("403")) return "Forbidden";
            else if (Status_Code.Equals("404")) return "Not Found";
            else if (Status_Code.Equals("405")) return "Method Not Allowed";
            else if (Status_Code.Equals("406")) return "Not Acceptable";
            else if (Status_Code.Equals("407")) return "Proxy Authentication Required";
            else if (Status_Code.Equals("408")) return "Request Time-out";
            else if (Status_Code.Equals("409")) return "Conflict";
            else if (Status_Code.Equals("410")) return "Gone";
            else if (Status_Code.Equals("411")) return "Length Required";
            else if (Status_Code.Equals("412")) return "Precondition Failed";
            else if (Status_Code.Equals("413")) return "Request Entity Too Large";
            else if (Status_Code.Equals("414")) return "Request-URI Too Large";
            else if (Status_Code.Equals("415")) return "Unsupported Media Type";
            else if (Status_Code.Equals("416")) return "Requested range not satisfiable";
            else if (Status_Code.Equals("417")) return "Expectation Failed";
            else if (Status_Code.Equals("500")) return "Internal Server Error";
            else if (Status_Code.Equals("501")) return "Not Implemented";
            else if (Status_Code.Equals("502")) return "Bad Gateway";
            else if (Status_Code.Equals("503")) return "Service Unavailable";
            else if (Status_Code.Equals("504")) return "Gateway Time-out";
            else if (Status_Code.Equals("505")) return "HTTP Version not supported";
            else return null;


        }

        public static Response Create_Response(Request request)
        {
            if (request.Method.Equals("GET"))
                return GET(request);
            else if (request.Method.Equals("POST"))
                return POST(request);
            else if (request.Method.Equals("PUT"))
                return PUT(request);
            else if (request.Method.Equals("DELETE"))
                return DELETE(request);
            else
                return Method_Not_Allowed(request);


        }

        public static Response GET(Request request)
        {

            String Http_Version = null,
                   Status_Code = null,
                   Reason_Phrase = null,
                   Date = null,
                   Server = null,
                   Last_Modified = null,
                   Content_Length = null,
                   Content_Type = null,
                   Content_Disposition = null,
                   Connection = null;

            Byte[] HtmlPage = null;
            Byte[] Data = null;

            Http_Version = request.HTTP;
            Date = Get_Date();
            Server = "MAServer v1.0";
            Last_Modified = Get_Date();
            Connection = "close";

            if (request.URL.Equals(""))
            {
                HtmlPage = get_bytes(HomePage_Html());
                Status_Code = "200";
                Reason_Phrase = Get_Reason_Phrase(Status_Code);
                Content_Length = HtmlPage.Length.ToString();
                Content_Type = "text/html";
                Content_Disposition = String.Format("inline; filename=\"{0}\"", "MA.html");
                Data = null;
                return new Response(Http_Version, Status_Code, Reason_Phrase, Date, Server, Last_Modified, Content_Length, Content_Type, Content_Disposition, Connection, HtmlPage, Data);
            }
            else
            {

                int index = Convert.ToInt32(request.URL);
                if (DownloadList.Check_file_Exist(index))
                {
                    Status_Code = "200";
                    Reason_Phrase = Get_Reason_Phrase(Status_Code);
                    FileInfo Fileinfo = new FileInfo(DownloadList.GetFile_By_Index(index));
                    Content_Type = Get_Content_Type(Fileinfo);
                    Content_Disposition = String.Format("inline; filename=\"{0}\"", Fileinfo.Name);
                    FileStream Opened_File = Fileinfo.OpenRead();
                    BinaryReader File_Binary = new BinaryReader(Opened_File);
                    Data = new Byte[Opened_File.Length];
                    Content_Length = Data.Length.ToString();
                    File_Binary.Read(Data, 0, Data.Length);
                    Opened_File.Close();
                    return new Response(Http_Version, Status_Code, Reason_Phrase, Date, Server, Last_Modified, Content_Length, Content_Type, Content_Disposition, Connection, HtmlPage, Data);
                }

            }


            return new Response(Http_Version, Status_Code, Reason_Phrase, Date, Server, Last_Modified, Content_Length, Content_Type, Content_Disposition, Connection, HtmlPage, Data);

        }

        public static Response POST(Request request)
        {
            return null;
        }

        public static Response PUT(Request request)
        {
            return null;
        }
        public static Response DELETE(Request request)
        {
            return null;
        }

        public static Response Method_Not_Allowed(Request request)
        {
            return null;
        }

        public static Response Create_OK_Response()
        {
            return null;
        }
        public static Response Create_BadRequest_Response()
        {
            return null;
        }


        public static String HomePage_Html()
        {
            String Start_of_HomePage = " <!DOCTYPE html><html><head><meta charset=\"utf-8\"><title>MA Server</title><style>* { margin: 0; padding: 0; box-sizing: border-box; }body { font: 13px Helvetica, Arial; }form { background: #abc; padding: 3px; position: fixed; bottom: 0; width: 100%; }form input { border: 0; padding: 10px; width: 90%; margin-right: .5%; }form button { width: 9%; background: rgb(130, 224, 255); border: none; padding: 10px; }#messages { list-style-type: none; margin: 0; padding: 0; }#messages li { padding: 5px 10px; }#messages li:nth-child(odd) { background: #eee; }</style><link rel=\"stylesheet\" href=\"http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css\"><script src=\"https://ajax.googleapis.com/ajax/libs/jquery/1.12.0/jquery.min.js\"></script><script src=\"http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js\"></script><style>body{background-color:  #d1f2eb ;}</style></head><body><p align=\"center\" style=\"margin-top: 1em\"><font size=\"6\" face=\"sans-serif\"> MA Server v1.0.0 </font></p><ul id=\"messages\"></ul><form action=\"\"><input id=\"m\" autocomplete=\"off\" /><button>Send</button></form>";
            String Downloadlist = null;
            Boolean Check = false;
            String Start_of_table = null;
            String End_of_table = null;

            foreach (String file in DownloadList.download_list)
            {
                Check = true;
                int index = DownloadList.Get_File_Index(file);
                String[] fileDirectories = file.Split('\\');
                String Filename = fileDirectories[fileDirectories.Length - 1];
                Downloadlist += String.Format("<tr><td><font color=\"#1b2631\">{0}</font></td><td><font color=\"#1b2631\">{1}</font></td><td><a href=\"/Download:{0}\"><font color=\"#78281f\"target=\"_blank\">Download</font></a></td><td><a href=\"/Open:{0}\"><font color=\"#78281f\"target=\"_blank\">Open</font></a></td></tr>", index, Filename);

            }
            if (Check == true)
            {
                Start_of_table = "<div class=\"container\"><p align=\"center\" style=\"margin-top: 1em\"><font size=\"3\" face=\"sans-serif\"> Download List:</font></p><table class=\"table table-bordered\"><thead><tr><th>#</th><th>File Name</th><th>Download</th><th>Open</th></tr></thead><tbody>";
                End_of_table = "</tbody></table></div>";
            }

            String End_of_HomePage = "</body></html>";

            return Start_of_HomePage + Start_of_table + Downloadlist + End_of_table + End_of_HomePage;

        }
        private static Byte[] get_bytes(String s)
        {
            Byte[] b = new Byte[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                b[i] = (Byte)s[i];
            }

            return b;
        }



    }


}
