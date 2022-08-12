using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuickDBAccess.Utils {
	class ArgUtils {
		private static List<ArgHandler> handlers = new List<ArgHandler>();
		public class ArgHandler {
			public string flag;
			public string description;
			public int paramCount;
			public bool required;
			public EventHandler eventHandler;
			public bool insufficientParameters = false;
			public ArgHandler(EventHandler eventHandler) : this(true, eventHandler) { }
			public ArgHandler(bool required, EventHandler eventHandler) : this(required, null, 1, eventHandler) { }
			public ArgHandler(bool required, string flag, EventHandler eventHandler) : this(required, flag, 0, eventHandler) { }
			public ArgHandler(bool required, string flag, int paramCount, EventHandler eventHandler) : this(required, flag, "", 0, eventHandler) { }
			public ArgHandler(bool required, string flag, string description, int paramCount, EventHandler eventHandler) {
				this.required = required;
				this.flag = flag;
				this.description = description;
				this.paramCount = paramCount;
				this.eventHandler = eventHandler;
			}
		}
		public class ArgHandlerParams : EventArgs {
			public ArgHandler handler;
			public List<string> parameters;
			public ArgHandlerParams(List<string> parameters, ArgHandler handler) {
				this.handler = handler;
				this.parameters = parameters;
			}
		}
		public static void AddHandle(ArgHandler handler) {
			handlers.Add(handler);
		}
		public static bool Handle(string[] args) {
			List<int> handledParams = new List<int>();
			List<ArgHandler> handledHandlers = new List<ArgHandler>();
			foreach (ArgHandler handler in handlers) {
				bool handled = HandleHandler(args, handledParams, handler);
				if (handled) {
					handledHandlers.Add(handler);
				}
			}
			foreach (ArgHandler handler in handlers) {
				if ((handler.required && !handledHandlers.Contains(handler)) || handler.insufficientParameters) {
					MessageBox.Show("Insufficient parameters provided!");
					return false;
				}
			}
			for (int i = 0; i < args.Length; i++) {
				if (!handledParams.Contains(i)) {
					MessageBox.Show("Unrecognized parameter: " + args[i]);
					return false;
				}
			}
			return true;
		}
		private static bool HandleHandler(string[] args, List<int> handledParams, ArgHandler handler) {
			bool startedHandle = false;
			List<string> parameters = new List<string>();
			for (int i = 0; i < args.Length; i++) {
				string arg = args[i];
				bool argHandled = handledParams.Contains(i);
				if (argHandled) {
					if (startedHandle) {
						break;
					}
				} else {
					if (!startedHandle) {
						if (handler.flag != null) {
							if (arg == handler.flag) {
								startedHandle = true;
								handledParams.Add(i);
							}
						} else {
							startedHandle = true;
							parameters.Add(arg);
							handledParams.Add(i);
						}
					} else {
						if (parameters.Count < handler.paramCount) {
							parameters.Add(arg);
							handledParams.Add(i);
						} else {
							break;
						}
						if (parameters.Count >= handler.paramCount) {
							break;
						}
					}
				}
			}
			if (startedHandle) {
				if (parameters.Count == handler.paramCount) {
					handler.eventHandler.Invoke(null, new ArgHandlerParams(parameters, handler));
					return true;
				} else {
					handler.insufficientParameters = true;
					return false;
				}
			}
			return false;
		}
	}
}
