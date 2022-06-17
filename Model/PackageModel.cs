namespace notes_sync.Model
{
	public class PackageModel
	{
		//Package: qvge
		
		public string Package { get;set; }
		
		//Version: 0.6.1
		public string Version { get;set; }
		
		//Status: install ok installed
		public string Status { get;set; }
		
		//Priority: optional
		public string Priority { get;set; }
		
		//Section: editors
		public string Section { get;set; }
		
		//Source: https://github.com/ArsMasiuk/qvge
		public string Source { get;set; }
		
		//Maintainer: Ars L. Masiuk <ars.masiuk@gmail.com>
		public string Maintainer { get;set; }
		
		//Installed-Size: 2220 kB
		public string InstalledSize { get;set; }
		
		//Depends: libqt5widgets5 (>= 5.9)
		public string Depends { get;set; }
		
		//Recommends: graphviz (>= 2.38)
		public string Recommends { get;set; }
		
		//Homepage: https://github.com/ArsMasiuk/qvge
		public string Homepage { get;set; }
		
		//Download-Size: unknown
		public string DownloadSize { get;set; }
		
		//APT-Manual-Installed: yes
		public string AptManualInstalled { get;set; }
		
		//APT-Sources: /var/lib/dpkg/status
		public string AptSources { get;set; }
		
		//Description: Qt Visual Graph Editor
		// Application for viewing and manipulating small till middle-sized graphs.
		// .
		// QVGE supports several formats (GraphML, GEXF, GML, GraphViz/Dot).
		public string Description { get;set; }
	}	
}
