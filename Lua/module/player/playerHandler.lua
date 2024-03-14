local playerHandler = {}
local module = require("module.module")
local CodeType = require("module.handler.codeType")
local Vector2 = CS.UnityEngine.Vector2
local speed = 2
local Vector3 = CS.UnityEngine.Vector3
local event = require("module.event.event")
function playerHandler:Init()
	self.inputTend = Vector2.zero

	module.handler:AddCodeEvent(CodeType.W, self.Front, false, self)
	module.handler:AddCodeEvent(CodeType["-W"], self.UpKey, true, self)

	module.handler:AddCodeEvent(CodeType.S, self.Back, false, self)
	module.handler:AddCodeEvent(CodeType["-S"], self.UpKey, true, self)

	module.handler:AddCodeEvent(CodeType.A, self.Left, false, self)
	module.handler:AddCodeEvent(CodeType["-A"], self.UpKey, true, self)

	module.handler:AddCodeEvent(CodeType.D, self.Right, false, self)
	module.handler:AddCodeEvent(CodeType["-D"], self.UpKey, true, self)
end

function playerHandler:GetTend()
	return self.inputTend.sqrMagnitude
end
function playerHandler:Up()
	-- body
end

function playerHandler:Down()
	-- body
end

function playerHandler:Front(delta)
	self.inputTend.y = (self.inputTend.y + delta * speed) > 1 and 1 or self.inputTend.y + delta * speed
	event.tendKeyDown:trigger(self.inputTend.normalized)
end

function playerHandler:Back(delta)
	self.inputTend.y = self.inputTend.y - delta * speed < -1 and -1 or self.inputTend.y - delta * speed
	event.tendKeyDown:trigger(self.inputTend.normalized)
	-- body
end

function playerHandler:Left(delta)
	self.inputTend.x = self.inputTend.x - delta * speed < -1 and -1 or self.inputTend.x - delta * speed
	event.tendKeyDown:trigger(self.inputTend.normalized)
	-- body
end

function playerHandler:Right(delta)
	self.inputTend.x = self.inputTend.x + delta * speed > 1 and 1 or self.inputTend.x + delta * speed
	event.tendKeyDown:trigger(self.inputTend.normalized)
	-- body
end


function playerHandler:UpKey(delta)
	-- self.inputTend = Vector2.zero
end










return playerHandler