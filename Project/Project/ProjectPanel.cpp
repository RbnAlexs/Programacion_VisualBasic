#include "ProjectPanel.h"

BEGIN_EVENT_TABLE(ProjectPanel, MainPanel)
	EVT_BUTTON(ID_MAIN_OK, ProjectPanel::OnOK)
END_EVENT_TABLE()

ProjectPanel::ProjectPanel( wxWindow* parent )
	: MainPanel( parent )
{
}

ProjectPanel::~ProjectPanel()
{
}

void ProjectPanel::OnOK( wxCommandEvent& event )
{
	wxMessageBox( wxT("OK Button Pressed") );
}