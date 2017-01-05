#include "ProjectFrame.h"
#include "ProjectPanel.h"
#include "ProjectAbout.h"

BEGIN_EVENT_TABLE( ProjectFrame, MainFrame )
	EVT_MENU( ID_FILE_EXIT, ProjectFrame::OnExit )
	EVT_MENU( ID_HELP_ABOUT, ProjectFrame::OnAbout )
END_EVENT_TABLE()

ProjectFrame::ProjectFrame( wxWindow *parent, int id )
	: MainFrame( parent, id )
{
	wxBoxSizer* sizer = new wxBoxSizer( wxVERTICAL );
	wxPanel* panel = new ProjectPanel( this );
	sizer->Add( panel, 1, wxEXPAND );
	wxSize panelSize = panel->GetSize();
	this->SetSizerAndFit( sizer );
	this->SetClientSize( panelSize );	
}

void ProjectFrame::OnExit( wxCommandEvent& event )
{
	Close();
}

void ProjectFrame::OnAbout( wxCommandEvent& event )
{
	ProjectAbout* about = new ProjectAbout( this );
	about->Show();
}

ProjectFrame::~ProjectFrame()
{
}