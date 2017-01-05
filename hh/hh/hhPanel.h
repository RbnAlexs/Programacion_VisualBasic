#ifndef HHPANEL_H
#define HHPANEL_H

#include "hh_GUI.h"

class hhPanel : public MainPanel
{
public:
	hhPanel( wxWindow* parent );
	~hhPanel();

private:
	void OnOK( wxCommandEvent& event );
	DECLARE_EVENT_TABLE();
};

#endif //HHPANEL_H