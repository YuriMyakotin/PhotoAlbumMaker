var colour = ["#F3B200", "#77B900", "#AD103C", "#2572EB", "#632F00", "#B01E00", "#7200AC", "#006AC1", "#008287", "#56C5FF", "#4617B4", "#C1004F", "#00C13F", "#FF981D", "#FF2E12", "#199900", "#FF1D77", "#AA40FF", "#1FAEFF", "#00D8CC", "#91D100", "#E1B700", "#FF76BC", "#00A3A3", "#FE7C22", "#647687"];
var CurrentFolderID = 0;
var Folders = [];
var SiteData;



$(document).ready(
	function () {

		$.getJSON("Site.json", function (data) {
			SiteData = data.valueOf();
			Folders = SiteData.F;
			window.sitestats.innerHTML = SiteData.TIC.toString() +
				" images, " +
				SiteData.TVC.toString() +
				" videos, last updated " +
				SiteData.LC;

			LoadAlbum(0);
		});


	});

function GetFolder(ID) {
	var cnt = Folders.length;
	for (let i = 0; i < cnt; i++) {
		if (Folders[i].I == ID) return Folders[i];
	}
	return Object();

}

function MakeNavStr() {
	var FolderID = CurrentFolderID;
	if (FolderID == 0) { window.NavStr.innerHTML = SiteData.N; return; };

	var F = GetFolder(FolderID);

	window.NavStr.innerHTML = F.N;
	while (true) {
		FolderID = F.PI;
		if (FolderID == 0) {
			window.NavStr.innerHTML = "<a href=\"#\" onclick=\"LoadAlbum(0)\">" + SiteData.N + "</a>&nbsp;>> " + window.NavStr.innerHTML;
			return;
		}
		F = GetFolder(FolderID);
		window.NavStr.innerHTML = "<a href=\"#\" onclick=\"LoadAlbum(" + FolderID + ")\">" + F.N + "</a>&nbsp;>> " + window.NavStr.innerHTML;
	}
}
function LoadAlbum(FolderID) {

	CurrentFolderID = FolderID; MakeNavStr();
	var DescText;
	if (FolderID == 0) {
		document.title = SiteData.N;
		DescText = SiteData.D;
	} else {
		var F = GetFolder(FolderID);
		document.title = F.N;
		DescText= F.C;
	}

	window.FolderDesc.innerText = DescText;
	if (DescText.length > 0) window.FolderDesc.style.display = "block";
	else window.FolderDesc.style.display = "none";
	LoadSubfolders();
}




function LoadSubfolders() {
	window.VideosLst.outerHTML = "<div class=\"videos-list\" id=\"VideosLst\"></div>";
	window.ImgLst.outerHTML = "<div class=\"images-list\" id=\"ImgLst\"></div>";
	window.FoldersLst.outerHTML = "<div class=\"folders-list\" id=\"FoldersLst\"></div>";
	window.appendContent.outerHTML = "<div id=\"appendContent\" style=\"display: none;\"></div>";
	var i = CurrentFolderID;
	var cnt = Folders.length;
	if (cnt > 0) {
		window.FoldersLst.style.display = "block";
		for (let j = 0; j < cnt; j++) {

			if (Folders[j].PI == CurrentFolderID) {
				var F = Folders[j];
				var ThumbName = "/" + F.TF.toString() + "/thumbs/" + F.TN;
				var AFol = $("<a class=\"Fol\" id=\"f" +
					F.I.toString() +
					"\" title=\"" +
					F.D +
					"\" href=\"#\" onclick=\"LoadAlbum(" +
					F.I.toString() +
					")\"><img class=\"F\" src=\"" +
					ThumbName +
					"\"/><span class=\"folder-name\">" +
					F.N +
					"</span></a>");
				var bgColor = colour[i % colour.length];
				i++;
				AFol.css({
					backgroundColor: bgColor,
					width: SiteData.TS * 2,
					height: SiteData.TS + 8
				});
				$("#FoldersLst").append(AFol);
			}

		}


		$('#FoldersLst').masonry({
			itemSelector: '.Fol',
			"isFitWidth": true
		});
	}
	else window.FoldersLst.style.display = "none";

	if (CurrentFolderID == 0) return;

	var CurrentFolder = GetFolder(CurrentFolderID);

	cnt = CurrentFolder.V.length;
	if (cnt > 0)
	{
		window.VideosLst.style.display = "block";
		for (let j = 0; j < cnt; j++)
		{
			var V = CurrentFolder.V[j];
			var AVid = $("<a class=\"Vid\" data-fancybox=\"Vid\" title=\"" + V.D + " \" href=\"Videos/" + V.N.toString() + "\" data-gallery=\"gallery1\"><img class=\"V\" src=\"/Content/Video.png\" height=\"" + (SiteData.TS / 2).toString() + "\" width=\"" + (SiteData.TS / 2).toString() + "\" width=\"" + SiteData.TS.toString() + "\"><span class=\"video-name\">" + V.D + "</span></a>");
			var bgColor = colour[i % colour.length];
			i++;

			AVid.css({
				backgroundColor: bgColor,
				width: SiteData.TS * 1.5,
				height: SiteData.TS / 2 + 4
			});
			$("#VideosLst").append(AVid);

		}

		$('#VideosLst').masonry({
			itemSelector: '.Vid', "isFitWidth": true, transitionDuration: 0
		});

		$('[data-fancybox="Vid"]').fancybox({
			loop: true,
			animationEffect: false,
			transitionEffect: false,
			protection: true,
			buttons: ["close"],
			defaultType: "video",
			video: {
				tpl:
					'<video class="fancybox-video" controls controlsList="nodownload" oncontextmenu="return false;" poster="{{poster}}"><source src="{{src}}" type="{{format}}" /></video>"',
				autoStart: true
			}
		});

	} else window.VideosLst.style.display = "none";


	cnt = CurrentFolder.Im.length;
	if (cnt > 0) {
		for (let j = 0; j < cnt; j++) {
			var IM = CurrentFolder.Im[j];
			var AImg = $("<a rel=\"group\" title=\"" +
				IM.N +
				"\" href=\"" +
				CurrentFolderID.toString() +
				"/slides/" +
				IM.N +
				"\" class=\"Img\" data-fancybox=\"Img\"><img class=\"I\" src=\"" +
				CurrentFolderID.toString() +
				"/thumbs/" +
				IM.N +
				"\" /></a>");
			AImg.css({
				width: SiteData.TS,
				height: SiteData.TS
			});
			$("#ImgLst").append(AImg);
			var InfoStr = "<br/><div>";
			if (IM.C != null) InfoStr += "<span class=\"cmnt\">" + IM.C + "</span><br />";
			InfoStr+="<a class=\"OrigImgLink\" href=\"" +
				CurrentFolderID.toString() + "/" + IM.N + "\" target=\"_blank\" title=\"Original image\">"+IM.N +"</a><br />";
			InfoStr += IM.E + "<br />";
			if (IM.G != null)
				InfoStr += "Geotag: <a href=\"https://www.google.com/maps/dir//" +
					IM.G +
					"/@" +
					IM.G +
					",18z\" target=\"_blank\">" +
					IM.G +
					"</a>";
			else InfoStr += "&nbsp;";

			InfoStr += "<br /></div>";
			$("#appendContent").append(InfoStr);
		}


		$('#ImgLst').masonry({ itemSelector: '.Img', "isFitWidth": true, transitionDuration: 0 });


		$('[data-fancybox="Img"]').fancybox({
			afterShow: function(instance, slide) {
				var toolbar = "<div id='tools'>" + $("#appendContent div").eq(this.index).html() + "</div>";
				$(".fancybox-title").append(toolbar);
			},

			caption: function(instance, item) { return "<div class=\"fancybox-title\"></div>"; },
			loop: true,
			animationEffect: false,
			transitionEffect: false,
			protection: true,
			image: { preload: true },
			buttons: ["slideShow", "thumbs", "close"]
		});
	}

}