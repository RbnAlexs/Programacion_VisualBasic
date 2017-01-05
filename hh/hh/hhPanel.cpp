#include "hhPanel.h"

BEGIN_EVENT_TABLE(hhPanel, MainPanel)
	EVT_BUTTON(ID_MAIN_OK, hhPanel::OnOK)
END_EVENT_TABLE()

hhPanel::hhPanel( wxWindow* parent )
	: MainPanel( parent )
{
}

hhPanel::~hhPanel()
{
}

void hhPanel::OnOK( wxCommandEvent& event )
{
	wxMessageBox( wxT("OK Button Pressed") );
}