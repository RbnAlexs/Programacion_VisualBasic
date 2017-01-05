#include "Project.h"
#include "ProjectAbout.h"
#include "fileversion.h"

// About dialog's event loop.
// Not needed because we only have a default OK button.
//BEGIN_EVENT_TABLE( ProjectAbout, AboutDlg )
	//EVT_BUTTON( wxID_OK, ProjectAbout::OnOK )
//END_EVENT_TABLE()

ProjectAbout::ProjectAbout( wxWindow* parent )
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
