#include "hh.h"
#include "hhAbout.h"
#include "fileversion.h"

// About dialog's event loop.
// Not needed because we only have a default OK button.
//BEGIN_EVENT_TABLE( hhAbout, AboutDlg )
	//EVT_BUTTON( wxID_OK, hhAbout::OnOK )
//END_EVENT_TABLE()

hhAbout::hhAbout( wxWindow* parent )
	: AboutDlg( parent, -1 )
{
	wxFileVersion ver;
	
	// Open the current executable's version information.
	ver.Open();
	
	// Get the file version.
	wxString fileVersion = ver.GetFixedFileVersion( true );
	
	// Set the version label.
	m_staticVersion->SetLabel( m_staticVersion->GetLabel() + wxT(" ") + fileVersion );
	
	// Resize to fit the contents.
	this->GetSizer()->SetSizeHints( this );
}
