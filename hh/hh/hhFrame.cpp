#include "hhFrame.h"
#include "hhPanel.h"
#include "hhAbout.h"

BEGIN_EVENT_TABLE( hhFrame, MainFrame )
	EVT_MENU( ID_FILE_EXIT, hhFrame::OnExit )
	EVT_MENU( ID_HELP_ABOUT, hhFrame::OnAbout )
END_EVENT_TABLE()

hhFrame::hhFrame( wxWindow *parent, int id )
	: MainFrame( parent, id )
{
	wxBoxSizer* sizer = new wxBoxSizer( wxVERTICAL );
	wxPanel* panel = new hhPanel( this );
	sizer->Add( panel, 1, wxEXPAND );
	wxSize panelSize = panel->GetSize();
	this->SetSizerAndFit( sizer );
	this->SetClientSize( panelSize );	
}

void hhFrame::OnExit( wxCommandEvent& event )
{
	Close();
}

void hhFrame::OnAbout( wxCommandEvent& event )
{
	hhAbout* about = new hhAbout( this );
	about->Show();
}

hhFrame::~hhFrame()
{
}